using BookStore.Application.Interfaces;
using BookStore.Domain.Entities;

namespace BookStore.Infrastructure.Persistence.Repositories;

public class OrderRepository : IOrderRepository
{
    public Task AddAsync(Order order)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Order order)
    {
        throw new NotImplementedException();
    }

    public Task<List<Order>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Order?> GetByIdAsync(long orderId)
    {
        throw new NotImplementedException();
    }

    public Task<List<Order>> GetByUserIdAsync(long userId)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Order order)
    {
        throw new NotImplementedException();
    }
}
