using BookStore.Application.Dtos.Auth;
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
    private readonly IUserRepository UserRepository;
    private readonly ITokenService TokenService;
    private readonly IRefreshTokenRepository RefreshTokenRepository;
    private readonly IUserRoleRepository UserRoleRepository;

    public AuthService(IUserRepository userRepositroy, ITokenService tokenService, IRefreshTokenRepository refreshTokenRepository, IUserRoleRepository userRoleRepository)
    {
        UserRepository = userRepositroy;
        TokenService = tokenService;
        RefreshTokenRepository = refreshTokenRepository;
        UserRoleRepository = userRoleRepository;
    }

    public Task<LogInResponseDto> LoginUserAsync(UserLogInDto userLogInDto)
    {
        var logInValidator = new UserLogInDtoValidator();
        var result = logInValidator.Validate(userLogInDto);

        if (!result.IsValid)
        {
            var errors = string.Join("\n", result.Errors.Select(e => e.ErrorMessage));
            throw new ValidationFailedException(errors);
        }


        var user = await UserRepositroy.SelectUserByUserNameAsync(userLogInDto.UserName);

        var checkUserPassword = PasswordHasher.Verify(userLogInDto.Password, user.Password, user.Salt);
        if (checkUserPassword == false)
        {
            throw new UnauthorizedException("User or password incorrect");
        }

        var userGetDto = new UserGetDto()
        {
            UserId = user.UserId,
            UserName = user.UserName,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Email = user.Email,
            PhoneNumber = user.PhoneNumber,
            Role = user.UserRole.UserRoleName,
        };

        var token = TokenService.GenerateTokent(userGetDto);
        var existingToken = await RefreshTokenRepository.SelectActiveTokenByUserIdAsync(user.UserId);

        var loginResponseDto = new LogInResponseDto()
        {
            AccessToken = token,
            TokenType = "Bearer",
            Expires = 24,
        };

        if (existingToken == null)
        {
            var refreshToken = TokenService.GenerateRefreshToken();
            var refreshTokenToDB = new RefreshToken()
            {
                Token = refreshToken,
                Expires = DateTime.UtcNow.AddDays(21),
                IsRevoked = false,
                UserId = user.UserId,
            };

            await RefreshTokenRepository.InsertRefreshTokenAsync(refreshTokenToDB);

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
