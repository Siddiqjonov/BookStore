using BookStore.Domain.Entities;

namespace BookStore.Application.Interfaces;

public interface IBookRepository
{
    Task<Book?> GetByIdAsync(long bookId);
    Task<List<Book>> GetAllAsync();
    Task<List<Book>> GetByCategoryIdAsync(long categoryId);
    Task AddAsync(Book book);
    Task UpdateAsync(Book book);
    Task DeleteAsync(Book book);
}
