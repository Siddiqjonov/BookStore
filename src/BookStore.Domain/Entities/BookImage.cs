namespace BookStore.Domain.Entities;

public class BookImage
{
    public long Id { get; set; }

    public long BookId { get; set; }
    public string ImageUrl { get; set; } = string.Empty;

    public DateTime UploadedAt { get; set; } = DateTime.UtcNow;
}
