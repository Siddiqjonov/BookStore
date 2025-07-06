using BookStore.Domain.Enums;

namespace BookStore.Domain.Entities;

public class User
{
    public long UserId { get; set; }

    public string FirstName { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public string Salt { get; set; } = string.Empty;

    public UserRole Role { get; set; } = UserRole.User;

    public bool EmailConfirmed { get; set; } = false;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
