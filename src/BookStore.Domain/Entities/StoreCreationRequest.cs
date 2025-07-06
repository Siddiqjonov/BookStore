using BookStore.Domain.Enums;

namespace BookStore.Domain.Entities;

public class StoreCreationRequest
{
    public long Id { get; set; }

    public long RequestedByUserId { get; set; }
    public string StoreName { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public RequestStatus Status { get; set; } = RequestStatus.Pending;
    public DateTime RequestedAt { get; set; } = DateTime.UtcNow;
}
