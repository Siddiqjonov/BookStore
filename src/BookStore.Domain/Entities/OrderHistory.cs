using BookStore.Domain.Enums;

namespace BookStore.Domain.Entities;

public class OrderHistory
{
    public long Id { get; set; }

    public long OrderId { get; set; }
    public OrderStatus Status { get; set; }

    public DateTime ChangedAt { get; set; } = DateTime.UtcNow;
    public string? ChangedBy { get; set; } // Username or role
}
