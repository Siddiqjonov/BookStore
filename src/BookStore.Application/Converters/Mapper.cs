using BookStore.Application.Dtos.Enums;
using BookStore.Application.Dtos.User;
using BookStore.Domain.Entities;

namespace BookStore.Application.Converters;

public static class Mapper
{
    public static UserGetDto MapUserToUserGetDto(User user)
    {
        return new UserGetDto()
        {
            UserId = user.UserId,
            Username = user.Username,
            FirstName = user.FirstName,
            Email = user.Email,
            PhoneNumber = user.PhoneNumber,
            Role = (UserRoleDto)user.Role,
            CreatedAt = user.CreatedAt,
            EmailConfirmed = user.EmailConfirmed,
            DefaultAddressId = user.DefaultAddressId,
        };
    }
}
