﻿using BookStore.Application.Interfaces;
using BookStore.Domain.Entities;

namespace BookStore.Infrastructure.Persistence.Repositories;

public class RefreshTokenRepository : IRefreshTokenRepository
{
    public Task InsertRefreshTokenAsync(RefreshToken refreshToken)
    {
        throw new NotImplementedException();
    }

    public Task RemoveRefreshTokenAsync(string token)
    {
        throw new NotImplementedException();
    }

    public Task<RefreshToken?> SelectActiveTokenByUserIdAsync(long userId)
    {
        throw new NotImplementedException();
    }

    public Task<RefreshToken> SelectRefreshTokenAsync(string refreshToken, long userId)
    {
        throw new NotImplementedException();
    }
}
