using BookStore.Application.Dtos.User;
using System.Security.Claims;

namespace BookStore.Application.Helpers;

public interface ITokenService
{
    public string GenerateTokent(UserGetDto user);
    string GenerateRefreshToken();
    ClaimsPrincipal? GetPrincipalFromExpiredToken(string token);
}
