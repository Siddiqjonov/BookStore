using BookStore.Application.Interfaces;
using BookStore.Domain.Entities;

namespace BookStore.Infrastructure.Persistence.Repositories;

public class EmailVarificationCodeRepository : IEmailVarificationCodeRepository
{
    public Task AddAsync(EmailVerificationCode code)
    {
        throw new NotImplementedException();
    }

    public Task<EmailVerificationCode?> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<EmailVerificationCode?> GetByUserIdAsync(Guid userId)
    {
        throw new NotImplementedException();
    }

    public Task SendVerificationCodeAsync(string email, string code)
    {
        throw new NotImplementedException();
    }
}
