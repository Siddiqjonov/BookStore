namespace BookStore.Domain.Entities;

public class RefreshToken
{
    public long RefreshTokenId { get; set; }

    public string Token { get; set; } = string.Empty;
    public DateTime Expires { get; set; }
    public bool IsRevoked { get; set; } = false;

    public long UserId { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
