using BookStore.Domain.Entitie;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.Infrastructure.Persistence.Configurations;

public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
{
    public void Configure(EntityTypeBuilder<OrderItem> builder)
    {
        builder.HasKey(x => x.OrderItemId);

        builder.Property(x => x.UnitPrice)
               .HasColumnType("decimal(18,2)")
               .IsRequired();
    }
}
