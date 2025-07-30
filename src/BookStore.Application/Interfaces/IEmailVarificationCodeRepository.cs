using BookStore.Domain.Entities;

namespace BookStore.Application.Interfaces;

public interface IEmailVarificationCodeRepository
{
    Task SendVerificationCodeAsync(string email);
    Task<EmailVerificationCode?> GetByIdAsync(long id);
    Task<EmailVerificationCode?> GetByEmailAsync(string email);
    Task<bool> VerifyCodeAsync(string email, string code);
}
