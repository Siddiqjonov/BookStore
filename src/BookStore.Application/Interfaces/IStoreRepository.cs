using BookStore.Domain.Entities;

namespace BookStore.Application.Interfaces;

public interface IStoreRepository
{
    Task<Store?> GetByIdAsync(long storeId);
    Task<List<Store>> GetAllAsync();
    Task<List<Store>> GetByOwnerIdAsync(long ownerId);
    Task AddAsync(Store store);
    Task UpdateAsync(Store store);
    Task DeleteAsync(Store store);
}
