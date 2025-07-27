using BookStore.Domain.Entities;

namespace BookStore.Application.Interfaces;

public interface IOrderRepository
{
    Task<Order?> GetByIdAsync(long orderId);
    Task<List<Order>> GetByUserIdAsync(long userId);
    Task<List<Order>> GetAllAsync();
    Task AddAsync(Order order);
    Task UpdateAsync(Order order);
    Task DeleteAsync(Order order);
}
