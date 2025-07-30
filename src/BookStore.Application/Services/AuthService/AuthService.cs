using BookStore.Application.Converters;
using BookStore.Application.Dtos.Auth;
using BookStore.Application.Dtos.User;
using BookStore.Application.FluentValidations.AuthValidations;
using BookStore.Application.FluentValidations.UserValidations;
using BookStore.Application.Helpers;
using BookStore.Application.Helpers.Security;
using BookStore.Application.Interfaces;
using BookStore.Domain.Entities;
using BookStore.Domain.Errors;

namespace BookStore.Application.Services.AuthService;

public class AuthService : IAuthService
{
    private readonly IUserRepository _userRepository;
    private readonly ITokenService _tokenService;
    private readonly IRefreshTokenRepository _refreshTokenRepository;
    private readonly IEmailVarificationCodeRepository _emailVarificationCodeRepository;

    public AuthService(IUserRepository userRepository, ITokenService tokenService, IRefreshTokenRepository refreshTokenRepository, IEmailVarificationCodeRepository emailVarificationCodeRepository)
    {
        _userRepository = userRepository;
        _tokenService = tokenService;
        _refreshTokenRepository = refreshTokenRepository;
        _emailVarificationCodeRepository = emailVarificationCodeRepository;
    }

    public async Task<LogInResponseDto> LoginUserAsync(UserLogInDto userLogInDto)
    {
        var logInValidator = new UserLogInDtoValidator();
        var result = logInValidator.Validate(userLogInDto);

        if (!result.IsValid)
        {
            var errors = string.Join("\n", result.Errors.Select(e => e.ErrorMessage));
            throw new ValidationFailedException(errors);
        }


        var user = await _userRepository.SelectUserByUserNameAsync(userLogInDto.UserName)
            ?? throw new NotFoundException($"Username and/or Password is incorrect");

        var checkUserPassword = PasswordHasher.Verify(userLogInDto.Password, user.PasswordHash, user.Salt);
        if (!checkUserPassword)
        {
            throw new UnauthorizedException("Username and/or Password is incorrect");
        }

        var userGetDto = Mapper.MapUserToUserGetDto(user);

        var token = _tokenService.GenerateTokent(userGetDto);

        var existingToken = await _refreshTokenRepository.SelectActiveTokenByUserIdAsync(user.UserId);

        var loginResponseDto = new LogInResponseDto()
        {
            AccessToken = token,
            TokenType = "Bearer",
            Expires = 24,
        };

        if (existingToken == null)
        {
            var refreshToken = _tokenService.GenerateRefreshToken();
            var refreshTokenToDB = new RefreshToken()
            {
                Token = refreshToken,
                Expires = DateTime.UtcNow.AddDays(21),
                IsRevoked = false,
                UserId = user.UserId,
            };

            await _refreshTokenRepository.InsertRefreshTokenAsync(refreshTokenToDB);

            loginResponseDto.RefreshToken = refreshToken;
        }
        else
        {
            loginResponseDto.RefreshToken = existingToken.Token;
        }

        return loginResponseDto;
    }

    public async Task LogOutAsync(string token)
    {
        await _refreshTokenRepository.RemoveRefreshTokenAsync(token);
    }

    public async Task<LogInResponseDto> RefreshTokenAsync(RefreshRequestDto request)
    {
        var principal = _tokenService.GetPrincipalFromExpiredToken(request.AccessToken);
        if (principal == null) throw new ForbiddenException("Invalid Access token");

        var userId = long.Parse(principal.FindFirst("UserId")!.Value);

        var refreshToken = await _refreshTokenRepository.SelectRefreshTokenAsync(request.RefreshToken, userId);
        if (refreshToken == null || refreshToken.Expires < DateTime.UtcNow || refreshToken.IsRevoked)
            throw new UnauthorizedAccessException("Invalid or expired refresh token");

        // make refresh token used
        refreshToken.IsRevoked = true;

        var user = await _userRepository.SelectUserByIdAsync(userId)
            ?? throw new NotFoundException("User not found by the given UserId from the token");

        var userGetDto = Mapper.MapUserToUserGetDto(user);

        // issue new tokens
        var newAccessToken = _tokenService.GenerateTokent(userGetDto);
        var newRefreshToken = _tokenService.GenerateRefreshToken();

        var refreshTokenToDB = new RefreshToken()
        {
            Token = newRefreshToken,
            Expires = DateTime.UtcNow.AddDays(21),
            IsRevoked = false,
            UserId = user.UserId,
        };

        await _refreshTokenRepository.InsertRefreshTokenAsync(refreshTokenToDB);

        return new LogInResponseDto()
        {
            AccessToken = newAccessToken,
            TokenType = "Bearer",
            RefreshToken = newRefreshToken,
            Expires = 24,
        };
    }

    public async Task<long> SignUpUserAsync(UserCreateDto userCreateDto)
    {
        var userValidator = new UserCreateDtoValidator();
        var result = userValidator.Validate(userCreateDto);

        if (!result.IsValid)
            throw new ValidationFailedException(string.Join("; ", result.Errors.Select(e => e.ErrorMessage)));

        var user = Mapper.MapUserCreateDtoToUser(userCreateDto);

        return await _userRepository.InsertUserAsync(user);
    }
}
