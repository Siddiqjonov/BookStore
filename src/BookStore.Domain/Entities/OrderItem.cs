namespace BookStore.Domain.Entitie;

public class OrderItem
{
    public long OrderItemId { get; set; }

    public long OrderId { get; set; }
    public long BookId { get; set; }

    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
}
