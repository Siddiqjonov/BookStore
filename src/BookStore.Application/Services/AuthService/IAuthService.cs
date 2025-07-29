using BookStore.Application.Dtos.Auth;
using BookStore.Application.Dtos.User;

namespace BookStore.Application.Services.AuthService;

public interface IAuthService
{
    Task<long> SignUpUserAsync(UserCreateDto userCreateDto);
    Task<LogInResponseDto> LoginUserAsync(UserLogInDto userLogInDto);
    Task<LogInResponseDto> RefreshTokenAsync(RefreshRequestDto request);
    Task LogOutAsync(string token);
}