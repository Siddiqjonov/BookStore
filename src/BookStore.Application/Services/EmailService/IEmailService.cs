using BookStore.Application.Dtos.Email;

namespace BookStore.Application.Services.EmailService;

public interface IEmailService
{
    Task<bool> VerifyCodeAsync(EmailCodeVerifyDto emailCodeVerifyDto);
}