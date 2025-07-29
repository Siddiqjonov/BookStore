namespace BookStore.Application.Dtos.Auth;

public class LogInResponseDto
{
    public string AccessToken { get; set; } = string.Empty;
    public string RefreshToken { get; set; } = string.Empty;
    public string TokenType { get; set; } = string.Empty;
    public int Expires { get; set; }
}
