using BookStore.Application.Dtos.Auth;
using BookStore.Application.Dtos.User;

namespace BookStore.Application.Services.AuthService;

public class AuthService : IAuthService
{
    public Task<LogInResponseDto> LoginUserAsync(UserLogInDto userLogInDto)
    {
        throw new NotImplementedException();
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
