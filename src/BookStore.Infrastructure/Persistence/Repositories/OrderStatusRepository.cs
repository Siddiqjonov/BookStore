using BookStore.Application.Interfaces;
using BookStore.Domain.Enums;

namespace BookStore.Infrastructure.Persistence.Repositories;

public class OrderStatusRepository : IOrderStatusRepository
{
    public Task AddAsync(OrderStatus orderStatus)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(OrderStatus orderStatus)
    {
        throw new NotImplementedException();
    }

    public Task<List<OrderStatus>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<OrderStatus?> GetByIdAsync(long orderStatusId)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(OrderStatus orderStatus)
    {
        throw new NotImplementedException();
    }
}
