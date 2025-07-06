using BookStore.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Infrastructure.Persistence.Configurations;

public class StoreCreationRequestConfiguration : IEntityTypeConfiguration<StoreCreationRequest>
{
    public void Configure(EntityTypeBuilder<StoreCreationRequest> builder)
    {
        builder.ToTable("StoreCreationRequests");

        builder.HasKey(r => r.Id);
        builder.Property(r => r.Status).HasConversion<string>();
    }
}
