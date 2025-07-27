using BookStore.Domain.Enums;

namespace BookStore.Application.Interfaces;

public interface IRequestStatusRepository
{
    Task<RequestStatus?> GetByIdAsync(long requestStatusId);
    Task<List<RequestStatus>> GetAllAsync();
    Task AddAsync(RequestStatus requestStatus);
    Task UpdateAsync(RequestStatus requestStatus);
    Task DeleteAsync(RequestStatus requestStatus);
}
