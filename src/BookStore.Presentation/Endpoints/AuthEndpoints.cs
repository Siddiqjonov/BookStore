using BookStore.Application.Dtos.Auth;
using BookStore.Application.Dtos.User;
using BookStore.Application.Errors;
using BookStore.Application.Services.AuthService;
using BookStore.Application.Services.UserService;

namespace BookStore.Presentation.Endpoints;

public static class AuthEndpoints
{
    public static void MapAuthEndpoints(this WebApplication app)
    {
        var userGroup = app.MapGroup("/api/auth")
            .WithTags("Auth endpoints");

        userGroup.MapPost("/signIn", SignIn)
            .WithName("LogIn");

        userGroup.MapPost("/sighUp", SignUp)
            .WithName("SignUp");

        userGroup.MapPost("/refreshToken", RefreshToken)
            .WithName("RefreshToken");

        userGroup.MapDelete("/LogOut", LogOut)
            .WithName("LogOut");
    }

    public static async Task<IResult> SignUp(UserCreateDto user, IAuthService _service)
    {
        return Results.Ok(await _service.SignUpUserAsync(user));
    }

    public static async Task<IResult> SignIn(UserLogInDto user, IAuthService _service)
    {
        return Results.Ok(await _service.LoginUserAsync(user));
    }

    public static async Task<IResult> RefreshToken(RefreshRequestDto refresh, IAuthService _service)
    {
        return Results.Ok(await _service.RefreshTokenAsync(refresh));
    }

    public static async Task<IResult> LogOut(string token, IAuthService _service)
    {
        await _service.LogOutAsync(token);
        return Results.Ok();
    }
}
