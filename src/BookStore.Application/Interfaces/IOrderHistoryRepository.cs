using BookStore.Domain.Entities;

namespace BookStore.Application.Interfaces;

public interface IOrderHistoryRepository
{
    Task<OrderHistory?> GetByIdAsync(long orderHistoryId);
    Task<List<OrderHistory>> GetByOrderIdAsync(long orderId);
    Task<List<OrderHistory>> GetAllAsync();
    Task AddAsync(OrderHistory orderHistory);
    Task UpdateAsync(OrderHistory orderHistory);
    Task DeleteAsync(OrderHistory orderHistory);
}
