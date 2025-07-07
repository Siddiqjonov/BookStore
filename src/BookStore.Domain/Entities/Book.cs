namespace BookStore.Domain.Entities;

public class Book
{
    public long Id { get; set; }

    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public string ISBN { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int Stock { get; set; }

    public long StoreId { get; set; }
    public long CategoryId { get; set; }

    public double AverageRating { get; set; } = 0.0;
    public int TotalSold { get; set; } = 0;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
