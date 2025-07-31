using BookStore.Application.Dtos.Email;
using BookStore.Application.Errors;
using BookStore.Application.FluentValidations.EmailValidations;
using BookStore.Application.Interfaces;

namespace BookStore.Application.Services.EmailService;

public class EmailService : IEmailService
{
    private readonly IEmailVarificationCodeRepository _emailVarificationCodeRepository;

    public EmailService(IEmailVarificationCodeRepository emailVarificationCodeRepository)
    {
        _emailVarificationCodeRepository = emailVarificationCodeRepository;
    }

    public async Task<bool> VerifyCodeAsync(EmailCodeVerifyDto emailCodeVerifyDto)
    {
        var validator = new EmailCodeVerifyDtoValidator();
        var result = validator.Validate(emailCodeVerifyDto);

        if (!result.IsValid)
            throw new ValidationFailedException(string.Join("; ", result.Errors.Select(e => e.ErrorMessage)));

        return await _emailVarificationCodeRepository.VerifyCodeAsync(emailCodeVerifyDto.Email, emailCodeVerifyDto.Code);
    }
}
