using BookStore.Application.Interfaces;
using BookStore.Domain.Entities;

namespace BookStore.Infrastructure.Persistence.Repositories;

public class BookImageRepository : IBookImageRepository
{
    public Task AddAsync(BookImage image)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(BookImage image)
    {
        throw new NotImplementedException();
    }

    public Task<List<BookImage>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<List<BookImage>> GetByBookIdAsync(long bookId)
    {
        throw new NotImplementedException();
    }

    public Task<BookImage?> GetByIdAsync(long bookImageId)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(BookImage image)
    {
        throw new NotImplementedException();
    }
}
