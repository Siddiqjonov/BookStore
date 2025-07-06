using BookStore.Domain.Enums;

namespace BookStore.Domain.Entities;

public class Order
{
    public long Id { get; set; }

    public long BookId { get; set; }
    public long UserId { get; set; }
    public int Quantity { get; set; }

    public OrderStatus Status { get; set; } = OrderStatus.Collecting;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? DeliveryStartedAt { get; set; }
}
