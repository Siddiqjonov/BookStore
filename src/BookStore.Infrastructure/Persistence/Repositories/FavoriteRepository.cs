using BookStore.Application.Interfaces;
using BookStore.Domain.Entities;

namespace BookStore.Infrastructure.Persistence.Repositories;

public class FavoriteRepository : IFavoriteRepository
{
    public Task AddAsync(Favorite favorite)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Favorite favorite)
    {
        throw new NotImplementedException();
    }

    public Task<List<Favorite>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Favorite?> GetByIdAsync(long favoriteId)
    {
        throw new NotImplementedException();
    }

    public Task<List<Favorite>> GetByUserIdAsync(long userId)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Favorite favorite)
    {
        throw new NotImplementedException();
    }
}
