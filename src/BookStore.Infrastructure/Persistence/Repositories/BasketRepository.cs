﻿using BookStore.Application.Interfaces;
using BookStore.Domain.Entities;

namespace BookStore.Infrastructure.Persistence.Repositories;

public class BasketRepository : IBasketRepository
{
    public Task AddAsync(Basket basket)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Basket basket)
    {
        throw new NotImplementedException();
    }

    public Task<List<Basket>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Basket?> GetByIdAsync(long basketId)
    {
        throw new NotImplementedException();
    }

    public Task<Basket?> GetByUserIdAsync(long userId)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Basket basket)
    {
        throw new NotImplementedException();
    }
}
