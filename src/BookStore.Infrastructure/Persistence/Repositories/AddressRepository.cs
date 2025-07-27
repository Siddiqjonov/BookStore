using BookStore.Application.Interfaces;
using BookStore.Domain.Entities;

namespace BookStore.Infrastructure.Persistence.Repositories;

public class AddressRepository : IAddressRepository
{
    public Task<long> AddAsync(Address address)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Address address)
    {
        throw new NotImplementedException();
    }

    public Task<List<Address>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Address?> GetByIdAsync(long addressId)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Address address)
    {
        throw new NotImplementedException();
    }
}
