using BookStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.Infrastructure.Persistence.Configurations;

public class BookImageConfiguration : IEntityTypeConfiguration<BookImage>
{
    public void Configure(EntityTypeBuilder<BookImage> builder)
    {
        builder.ToTable("BookImages");

        builder.HasKey(b => b.Id);
        builder.Property(b => b.ImageUrl).IsRequired().HasMaxLength(500);
    }
}
