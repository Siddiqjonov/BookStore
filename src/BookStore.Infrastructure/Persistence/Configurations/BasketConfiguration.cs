using BookStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.Infrastructure.Persistence.Configurations;

public class BasketConfiguration : IEntityTypeConfiguration<Basket>
{
    public void Configure(EntityTypeBuilder<Basket> builder)
    {
        builder.HasKey(x => x.BasketId);

        builder.Property(x => x.CreatedAt)
               .HasDefaultValueSql("CURRENT_TIMESTAMP");

        builder.HasMany(x => x.Items)
               .WithOne()
               .HasForeignKey(x => x.Id)
               .OnDelete(DeleteBehavior.Cascade);
    }
}
