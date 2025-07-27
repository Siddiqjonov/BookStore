using BookStore.Domain.Enums;

namespace BookStore.Application.Interfaces;

public interface IUserRoleRepository
{
    Task<UserRole?> GetByIdAsync(long userRoleId);
    Task<List<UserRole>> GetAllAsync();
    Task AddAsync(UserRole userRole);
    Task UpdateAsync(UserRole userRole);
    Task DeleteAsync(UserRole userRole);
}
