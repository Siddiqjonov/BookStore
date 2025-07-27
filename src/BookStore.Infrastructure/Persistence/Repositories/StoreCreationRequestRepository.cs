using BookStore.Application.Interfaces;
using BookStore.Domain.Entities;

namespace BookStore.Infrastructure.Persistence.Repositories;

public class StoreCreationRequestRepository : IStoreCreationRequestRepository
{
    public Task AddAsync(StoreCreationRequest request)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(StoreCreationRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<List<StoreCreationRequest>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<StoreCreationRequest?> GetByIdAsync(long requestId)
    {
        throw new NotImplementedException();
    }

    public Task<List<StoreCreationRequest>> GetByUserIdAsync(long userId)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(StoreCreationRequest request)
    {
        throw new NotImplementedException();
    }
}
