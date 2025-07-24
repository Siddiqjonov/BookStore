using BookStore.Domain.Entities;
using BookStore.Infrastructure.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Infrastructure.Persistence.DataContext;
public class UserDbContext : DbContext
{
    public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) { }

    public DbSet<User> Users => Set<User>();
    public DbSet<Address> Addresses => Set<Address>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new AddressConfiguration());
    }
}
