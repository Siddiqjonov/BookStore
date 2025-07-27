using BookStore.Domain.Entities;

namespace BookStore.Application.Interfaces;

public interface IEmailVarificationCodeRepository
{
    Task SendVerificationCodeAsync(string email, string code);
    Task<EmailVerificationCode?> GetByIdAsync(long id);
    Task<EmailVerificationCode?> GetByUserIdAsync(Guid userId);
    Task AddAsync(EmailVerificationCode code);
}
