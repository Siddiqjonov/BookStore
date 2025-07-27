using BookStore.Application.Interfaces;
using BookStore.Domain.Enums;

namespace BookStore.Infrastructure.Persistence.Repositories;

public class RequestStatusRepository : IRequestStatusRepository
{
    public Task AddAsync(RequestStatus requestStatus)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(RequestStatus requestStatus)
    {
        throw new NotImplementedException();
    }

    public Task<List<RequestStatus>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<RequestStatus?> GetByIdAsync(long requestStatusId)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(RequestStatus requestStatus)
    {
        throw new NotImplementedException();
    }
}
