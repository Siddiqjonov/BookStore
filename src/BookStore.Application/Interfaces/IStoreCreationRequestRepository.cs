using BookStore.Domain.Entities;

namespace BookStore.Application.Interfaces;

public interface IStoreCreationRequestRepository
{
    Task<StoreCreationRequest?> GetByIdAsync(long requestId);
    Task<List<StoreCreationRequest>> GetAllAsync();
    Task<List<StoreCreationRequest>> GetByUserIdAsync(long userId);
    Task AddAsync(StoreCreationRequest request);
    Task UpdateAsync(StoreCreationRequest request);
    Task DeleteAsync(StoreCreationRequest request);
}
