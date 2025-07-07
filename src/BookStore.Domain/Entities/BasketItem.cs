namespace BookStore.Domain.Entities;

public class BasketItem
{
    public long Id { get; set; }

    public long UserId { get; set; }
    public long BookId { get; set; }

    public int Quantity { get; set; }

    public DateTime AddedAt { get; set; } = DateTime.UtcNow;
}
