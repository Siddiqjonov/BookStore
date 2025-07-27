using BookStore.Application.Interfaces;
using BookStore.Domain.Entities;

namespace BookStore.Infrastructure.Persistence.Repositories;

public class BookRatingRepository : IBookRatingRepository
{
    public Task AddAsync(BookRating rating)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(BookRating rating)
    {
        throw new NotImplementedException();
    }

    public Task<List<BookRating>> GetByBookIdAsync(long bookId)
    {
        throw new NotImplementedException();
    }

    public Task<BookRating?> GetByIdAsync(long ratingId)
    {
        throw new NotImplementedException();
    }

    public Task<List<BookRating>> GetByUserIdAsync(long userId)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(BookRating rating)
    {
        throw new NotImplementedException();
    }
}
