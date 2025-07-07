namespace BookStore.Domain.Entities;

public class Address
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public string Region { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string Street { get; set; } = string.Empty;
    public string Apartment { get; set; } = string.Empty;

    public bool IsCurrent { get; set; } = true;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}