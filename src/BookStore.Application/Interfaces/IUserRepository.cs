﻿using BookStore.Domain.Entities;

namespace BookStore.Application.Interfaces;

public interface IUserRepository
{
    Task<User?> GetByIdAsync(long userId);
    Task<User?> GetByEmailAsync(string email);
    Task<List<User>> GetAllAsync();
    Task<long> InsertUserAsync(User user);
    Task UpdateAsync(User user);
    Task DeleteAsync(User user);
    Task<User?> SelectUserByUserNameAsync(string userName);
    Task<User?> SelectUserByIdAsync(long userId);
}
