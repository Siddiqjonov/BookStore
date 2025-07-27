using BookStore.Application.Interfaces;
using BookStore.Domain.Entities;

namespace BookStore.Infrastructure.Persistence.Repositories;

public class BookRepository : IBookRepository
{
    public Task AddAsync(Book book)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Book book)
    {
        throw new NotImplementedException();
    }

    public Task<List<Book>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<List<Book>> GetByCategoryIdAsync(long categoryId)
    {
        throw new NotImplementedException();
    }

    public Task<Book?> GetByIdAsync(long bookId)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Book book)
    {
        throw new NotImplementedException();
    }
}
