using BookStore.Domain.Entities;

namespace BookStore.Application.Interfaces;

public interface IBasketRepository
{
    Task<Basket?> GetByIdAsync(long basketId);
    Task<Basket?> GetByUserIdAsync(long userId);
    Task<List<Basket>> GetAllAsync();
    Task AddAsync(Basket basket);
    Task UpdateAsync(Basket basket);
    Task DeleteAsync(Basket basket);
}
