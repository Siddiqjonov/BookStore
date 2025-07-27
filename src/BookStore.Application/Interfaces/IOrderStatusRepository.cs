using BookStore.Domain.Enums;

namespace BookStore.Application.Interfaces;

public interface IOrderStatusRepository
{
    Task<OrderStatus?> GetByIdAsync(long orderStatusId);
    Task<List<OrderStatus>> GetAllAsync();
    Task AddAsync(OrderStatus orderStatus);
    Task UpdateAsync(OrderStatus orderStatus);
    Task DeleteAsync(OrderStatus orderStatus);
}
