namespace BookStore.Domain.Entities;

public class EmailVerificationCode
{
    public long Id { get; set; }

    public string Email { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime ExpiresAt { get; set; } = DateTime.UtcNow.AddHours(2);
    public bool IsUsed { get; set; } = false;
}
