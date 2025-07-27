using BookStore.Domain.Entities;

namespace BookStore.Application.Interfaces;

public interface IBookCategoryRepository
{
    Task<BookCategory?> GetByIdAsync(long bookCategoryId);
    Task<List<BookCategory>> GetAllAsync();
    Task AddAsync(BookCategory category);
    Task UpdateAsync(BookCategory category);
    Task DeleteAsync(BookCategory category);
}
