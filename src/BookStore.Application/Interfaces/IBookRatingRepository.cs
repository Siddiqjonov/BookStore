using BookStore.Domain.Entities;

namespace BookStore.Application.Interfaces;

public interface IBookRatingRepository
{
    Task<BookRating?> GetByIdAsync(long ratingId);
    Task<List<BookRating>> GetByBookIdAsync(long bookId);
    Task<List<BookRating>> GetByUserIdAsync(long userId);
    Task AddAsync(BookRating rating);
    Task UpdateAsync(BookRating rating);
    Task DeleteAsync(BookRating rating);
}
