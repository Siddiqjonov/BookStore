namespace BookStore.Application.Dtos.Email;

public class EmailCodeVerifyDto
{
    public string Email { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
}
