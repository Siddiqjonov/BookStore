namespace BookStore.Domain.Entities;

public class Favorite
{
    public long Id { get; set; }

    public long UserId { get; set; }
    public long BookId { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
