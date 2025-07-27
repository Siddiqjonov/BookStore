using BookStore.Application.Interfaces;
using BookStore.Domain.Entitie;

namespace BookStore.Infrastructure.Persistence.Repositories;

public class OrderItemRepository : IOrderItemRepository
{
    public Task AddAsync(OrderItem orderItem)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(OrderItem orderItem)
    {
        throw new NotImplementedException();
    }

    public Task<List<OrderItem>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<OrderItem?> GetByIdAsync(long orderItemId)
    {
        throw new NotImplementedException();
    }

    public Task<List<OrderItem>> GetByOrderIdAsync(long orderId)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(OrderItem orderItem)
    {
        throw new NotImplementedException();
    }
}
