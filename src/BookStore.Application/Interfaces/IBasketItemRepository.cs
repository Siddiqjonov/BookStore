using BookStore.Domain.Entities;

namespace BookStore.Application.Interfaces;

public interface IBasketItemRepository
{
    Task<BasketItem?> GetByIdAsync(long basketItemId);
    Task<List<BasketItem>> GetByBasketIdAsync(long basketId);
    Task<List<BasketItem>> GetAllAsync();
    Task AddAsync(BasketItem basketItem);
    Task UpdateAsync(BasketItem basketItem);
    Task DeleteAsync(BasketItem basketItem);
}
