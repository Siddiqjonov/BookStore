namespace BookStore.Domain.Entities;

public class BookRating
{
    public long Id { get; set; }

    public long BookId { get; set; }
    public long UserId { get; set; }

    public int Stars { get; set; } // from 1 to 5
    public string? Comment { get; set; }

    public DateTime RatedAt { get; set; } = DateTime.UtcNow;
}
