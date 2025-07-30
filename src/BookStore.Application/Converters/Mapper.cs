using BookStore.Application.Dtos.Enums;
using BookStore.Application.Dtos.User;
using BookStore.Application.Helpers.Security;
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

    public static User MapUserCreateDtoToUser(UserCreateDto userCreateDto)
    {
        var (Hash, Salt) = PasswordHasher.Hasher(userCreateDto.Password);

        return new User()
        {
            FirstName = userCreateDto.FirstName,
            Username = userCreateDto.Username,
            Email = userCreateDto.Email,
            PhoneNumber = userCreateDto.PhoneNumber,
            PasswordHash = Hash,
            Salt = Salt,
            CreatedAt = DateTime.UtcNow,
            Role = (Domain.Enums.UserRole)UserRoleDto.User,
        };
    }
}
