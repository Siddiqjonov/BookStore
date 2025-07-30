using BookStore.Application.Converters;
using BookStore.Application.Dtos.Auth;
using BookStore.Application.Dtos.Enums;
using BookStore.Application.Dtos.User;
using BookStore.Application.FluentValidations.AuthValidations;
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
    private readonly IUserRoleRepository _userRoleRepository;

    public AuthService(IUserRepository userRepository, ITokenService tokenService, IRefreshTokenRepository refreshTokenRepository, IUserRoleRepository userRoleRepository)
    {
        _userRepository = userRepository;
        _tokenService = tokenService;
        _refreshTokenRepository = refreshTokenRepository;
        _userRoleRepository = userRoleRepository;
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
        if (checkUserPassword == false)
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

    public Task LogOutAsync(string token)
    {
        throw new NotImplementedException();
    }

    public Task<LogInResponseDto> RefreshTokenAsync(RefreshRequestDto request)
    {
        throw new NotImplementedException();
    }

    public Task<long> SignUpUserAsync(UserCreateDto userCreateDto)
    {
        throw new NotImplementedException();
    }
}
