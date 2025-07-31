using BookStore.Application.Dtos.Email;
using FluentValidation;

namespace BookStore.Application.FluentValidations.EmailValidations;

public class EmailCodeVerifyDtoValidator : AbstractValidator<EmailCodeVerifyDto>
{
    public EmailCodeVerifyDtoValidator()
    {
        RuleFor(x => x.Email)
            .NotEmpty().WithMessage("Email is required.")
            .EmailAddress().WithMessage("Invalid email format.");

        RuleFor(x => x.Code)
            .NotEmpty().WithMessage("Code is required.")
            .Length(8).WithMessage("Code must be 8 characters long.")
            .Matches(@"^(?=.*[A-Z])(?=.*\d)[A-Z\d]{8}$")
            .WithMessage("Code must contain only uppercase letters and digits.");
    }
}
