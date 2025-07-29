using BookStore.Domain.Enums;

namespace BookStore.Application.Dtos.User;

public class UserCreateDto
{
    public string FirstName { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
}
