using BookStore.Domain.Entitie;

namespace BookStore.Application.Interfaces;

public interface IOrderItemRepository
{
    Task<OrderItem?> GetByIdAsync(long orderItemId);
    Task<List<OrderItem>> GetByOrderIdAsync(long orderId);
    Task<List<OrderItem>> GetAllAsync();
    Task AddAsync(OrderItem orderItem);
    Task UpdateAsync(OrderItem orderItem);
    Task DeleteAsync(OrderItem orderItem);
}
