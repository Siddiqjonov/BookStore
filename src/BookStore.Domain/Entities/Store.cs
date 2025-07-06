namespace BookStore.Domain.Entities;

public class Store
{
    public long Id { get; set; }

    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public long CreatedByUserId { get; set; }
    public bool IsApproved { get; set; } = false;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
