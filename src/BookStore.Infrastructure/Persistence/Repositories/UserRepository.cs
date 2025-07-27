using BookStore.Application.Interfaces;
using BookStore.Domain.Entities;

namespace BookStore.Infrastructure.Persistence.Repositories;

public class UserRepository : IUserRepository
{
    public Task AddAsync(User user)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(User user)
    {
        throw new NotImplementedException();
    }

    public Task<List<User>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<User?> GetByEmailAsync(string email)
    {
        throw new NotImplementedException();
    }

    public Task<User?> GetByIdAsync(long userId)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(User user)
    {
        throw new NotImplementedException();
    }
}
