using BookStore.Infrastructure.Persistence.DataContext;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Presentation.Configurations;

public static class DatabaseConfiguration
{
    public static void ConfigureSqlServerDatabase(this WebApplicationBuilder builder)
    {
        var connectionString = builder.Configuration.GetConnectionString("SqlServerConnection");

        builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(connectionString));
    }

    public static void ConfigurePostgresDatabase(this WebApplicationBuilder builder)
    {
        var connectionString = builder.Configuration.GetConnectionString("PostgresConnection");

        builder.Services.AddDbContext<UserDbContext>(options =>
            options.UseNpgsql(connectionString));
    }
}
    