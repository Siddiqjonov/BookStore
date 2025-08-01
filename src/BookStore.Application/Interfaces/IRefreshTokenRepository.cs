﻿using BookStore.Domain.Entities;

namespace BookStore.Application.Interfaces;

public interface IRefreshTokenRepository
{
    Task InsertRefreshTokenAsync(RefreshToken refreshToken);
    Task<RefreshToken> SelectRefreshTokenAsync(string refreshToken, long userId);
    Task<RefreshToken?> SelectActiveTokenByUserIdAsync(long userId);
    Task RemoveRefreshTokenAsync(string token);
}
