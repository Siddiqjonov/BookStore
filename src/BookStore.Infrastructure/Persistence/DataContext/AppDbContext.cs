using BookStore.Domain.Entitie;
using BookStore.Domain.Entities;
using BookStore.Infrastructure.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Infrastructure.Persistence.DataContext;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<BookCategory> BookCategories => Set<BookCategory>();
    public DbSet<BookImage> BookImages => Set<BookImage>();
    public DbSet<BookRating> BookRatings => Set<BookRating>();
    public DbSet<Favorite> Favorites => Set<Favorite>();
    public DbSet<Store> Stores => Set<Store>();
    public DbSet<StoreCreationRequest> StoreCreationRequests => Set<StoreCreationRequest>();
    public DbSet<EmailVerificationCode> EmailVerificationCodes => Set<EmailVerificationCode>();
    public DbSet<RefreshToken> RefreshTokens => Set<RefreshToken>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new BookCategoryConfiguration());
        modelBuilder.ApplyConfiguration(new BookImageConfiguration());
        modelBuilder.ApplyConfiguration(new BookRatingConfiguration());
        modelBuilder.ApplyConfiguration(new FavoriteConfiguration());
        modelBuilder.ApplyConfiguration(new StoreConfiguration());
        modelBuilder.ApplyConfiguration(new StoreCreationRequestConfiguration());
        modelBuilder.ApplyConfiguration(new EmailVerificationCodeConfiguration());
        modelBuilder.ApplyConfiguration(new RefreshTokenConfiguration());
    }
}
