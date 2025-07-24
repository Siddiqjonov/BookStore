using BookStore.Infrastructure.Persistence.DataContext;
using Microsoft.EntityFrameworkCore;
using System;

namespace BookStore.Presentation.Configurations;

public static class DatabaseConfiguration
{
    public static void ConfigureMySqlDb(this WebApplicationBuilder builder)
    {
        var connectionString = builder.Configuration.GetConnectionString("MySqlConnection");

        builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 36))));
    }


    public static void ConfigurePostgresDb(this WebApplicationBuilder builder)
    {
        var connectionString = builder.Configuration.GetConnectionString("PostgresConnection");

        builder.Services.AddDbContext<UserDbContext>(options =>
            options.UseNpgsql(connectionString));
    }
}
