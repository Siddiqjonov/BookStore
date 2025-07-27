using BookStore.Domain.Entities;

namespace BookStore.Application.Interfaces;

public interface IFavoriteRepository
{
    Task<Favorite?> GetByIdAsync(long favoriteId);
    Task<List<Favorite>> GetByUserIdAsync(long userId);
    Task<List<Favorite>> GetAllAsync();
    Task AddAsync(Favorite favorite);
    Task UpdateAsync(Favorite favorite);
    Task DeleteAsync(Favorite favorite);
}
