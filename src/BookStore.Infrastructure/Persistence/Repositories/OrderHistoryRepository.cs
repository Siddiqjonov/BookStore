using BookStore.Application.Interfaces;
using BookStore.Domain.Entities;

namespace BookStore.Infrastructure.Persistence.Repositories;

public class OrderHistoryRepository : IOrderHistoryRepository
{
    public Task AddAsync(OrderHistory orderHistory)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(OrderHistory orderHistory)
    {
        throw new NotImplementedException();
    }

    public Task<List<OrderHistory>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<OrderHistory?> GetByIdAsync(long orderHistoryId)
    {
        throw new NotImplementedException();
    }

    public Task<List<OrderHistory>> GetByOrderIdAsync(long orderId)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(OrderHistory orderHistory)
    {
        throw new NotImplementedException();
    }
}
