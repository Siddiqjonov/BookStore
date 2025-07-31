using BookStore.Application.Interfaces;
using BookStore.Application.Services.AuthService;
using BookStore.Application.Services.EmailService;
using BookStore.Application.Services.UserService;
using BookStore.Infrastructure.Persistence.Repositories;

namespace BookStore.Presentation.Configurations;

public static class DependencyInjectionConfiguration
{
    public static void RegisterRepositories(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IAddressRepository, AddressRepository>();
        builder.Services.AddScoped<IBasketItemRepository, BasketItemRepository>();
        builder.Services.AddScoped<IBasketRepository, BasketRepository>();
        builder.Services.AddScoped<IBookCategoryRepository, BookCategoryRepository>();
        builder.Services.AddScoped<IBookImageRepository, BookImageRepository>();
        builder.Services.AddScoped<IBookRatingRepository, BookRatingRepository>();
        builder.Services.AddScoped<IBookRepository, BookRepository>();
        builder.Services.AddScoped<IEmailVarificationCodeRepository, EmailVarificationCodeRepository>();
        builder.Services.AddScoped<IFavoriteRepository, FavoriteRepository>();
        builder.Services.AddScoped<IOrderHistoryRepository, OrderHistoryRepository>();
        builder.Services.AddScoped<IOrderItemRepository, OrderItemRepository>();
        builder.Services.AddScoped<IOrderRepository, OrderRepository>();
        builder.Services.AddScoped<IOrderStatusRepository, OrderStatusRepository>();
        builder.Services.AddScoped<IRefreshTokenRepository, RefreshTokenRepository>();
        builder.Services.AddScoped<IRequestStatusRepository, RequestStatusRepository>();
        builder.Services.AddScoped<IStoreCreationRequestRepository, StoreCreationRequestRepository>();
        builder.Services.AddScoped<IStoreRepository, StoreRepository>();
        builder.Services.AddScoped<IUserRepository, UserRepository> ();
        builder.Services.AddScoped<IUserRoleRepository, UserRoleRepository>();
    }

    public static void RegisterServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IAuthService, AuthService>();
        builder.Services.AddScoped<IEmailService, EmailService>();
        builder.Services.AddScoped<IUserService, UserService>();
    }
}
