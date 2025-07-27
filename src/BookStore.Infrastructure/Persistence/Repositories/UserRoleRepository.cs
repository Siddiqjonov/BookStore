using BookStore.Application.Interfaces;
using BookStore.Domain.Enums;

namespace BookStore.Infrastructure.Persistence.Repositories;

public class UserRoleRepository : IUserRoleRepository
{
    public Task AddAsync(UserRole userRole)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(UserRole userRole)
    {
        throw new NotImplementedException();
    }

    public Task<List<UserRole>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<UserRole?> GetByIdAsync(long userRoleId)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(UserRole userRole)
    {
        throw new NotImplementedException();
    }
}
