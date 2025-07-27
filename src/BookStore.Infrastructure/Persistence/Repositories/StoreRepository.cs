using BookStore.Application.Interfaces;
using BookStore.Domain.Entities;

namespace BookStore.Infrastructure.Persistence.Repositories;

public class StoreRepository : IStoreRepository
{
    public Task AddAsync(Store store)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Store store)
    {
        throw new NotImplementedException();
    }

    public Task<List<Store>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Store?> GetByIdAsync(long storeId)
    {
        throw new NotImplementedException();
    }

    public Task<List<Store>> GetByOwnerIdAsync(long ownerId)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Store store)
    {
        throw new NotImplementedException();
    }
}
