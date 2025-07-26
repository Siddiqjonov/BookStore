using BookStore.Domain.Entities;

namespace BookStore.Application.Interfaces;

public interface IAddressRepository
{
    Task<List<Address>> GetAllAsync();
    Task<Address?> GetByIdAsync(long addressId);
    Task<long> AddAsync(Address address);
    Task UpdateAsync(Address address);
    Task DeleteAsync(Address address);
}
