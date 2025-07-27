using BookStore.Application.Interfaces;
using BookStore.Domain.Entities;

namespace BookStore.Infrastructure.Persistence.Repositories;

public class BasketItemRepository : IBasketItemRepository
{
    public Task AddAsync(BasketItem basketItem)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(BasketItem basketItem)
    {
        throw new NotImplementedException();
    }

    public Task<List<BasketItem>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<List<BasketItem>> GetByBasketIdAsync(long basketId)
    {
        throw new NotImplementedException();
    }

    public Task<BasketItem?> GetByIdAsync(long basketItemId)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(BasketItem basketItem)
    {
        throw new NotImplementedException();
    }
}
