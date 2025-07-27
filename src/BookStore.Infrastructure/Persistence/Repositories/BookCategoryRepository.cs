using BookStore.Application.Interfaces;
using BookStore.Domain.Entities;

namespace BookStore.Infrastructure.Persistence.Repositories;

public class BookCategoryRepository : IBookCategoryRepository
{
    public Task AddAsync(BookCategory category)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(BookCategory category)
    {
        throw new NotImplementedException();
    }

    public Task<List<BookCategory>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<BookCategory?> GetByIdAsync(long bookCategoryId)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(BookCategory category)
    {
        throw new NotImplementedException();
    }
}
