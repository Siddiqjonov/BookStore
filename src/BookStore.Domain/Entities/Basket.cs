namespace BookStore.Domain.Entities;

public class Basket
{
    public long BasketId { get; set; }

    public long UserId { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public bool IsCheckedOut { get; set; } = false;

    public List<BasketItem> Items { get; set; } = new();
}
