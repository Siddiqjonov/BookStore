using BookStore.Domain.Entities;

namespace BookStore.Application.Interfaces;

public interface IBookImageRepository
{
    Task<BookImage?> GetByIdAsync(long bookImageId);
    Task<List<BookImage>> GetByBookIdAsync(long bookId);
    Task<List<BookImage>> GetAllAsync();
    Task AddAsync(BookImage image);
    Task UpdateAsync(BookImage image);
    Task DeleteAsync(BookImage image);
}
