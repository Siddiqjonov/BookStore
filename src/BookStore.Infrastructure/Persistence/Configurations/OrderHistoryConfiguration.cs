using BookStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.Infrastructure.Persistence.Configurations;

public class OrderHistoryConfiguration : IEntityTypeConfiguration<OrderHistory>
{
    public void Configure(EntityTypeBuilder<OrderHistory> builder)
    {
        builder.ToTable("OrderHistories");

        builder.HasKey(h => h.Id);
        builder.Property(h => h.Status).HasConversion<string>().IsRequired();
        builder.Property(h => h.ChangedBy).HasMaxLength(255);
    }
}
