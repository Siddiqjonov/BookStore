using BookStore.Application.Dtos.Auth;
using FluentValidation;

namespace BookStore.Application.FluentValidations.AuthValidations;

public class UserLogInDtoValidator : AbstractValidator<UserLogInDto>
{
    public UserLogInDtoValidator()
    {
        RuleFor(x => x.UserName)
            .NotEmpty().WithMessage("Username is required")
            .MinimumLength(3).WithMessage("Username must be at least 3 characters");

        RuleFor(x => x.Password)
            .NotEmpty().WithMessage("Password is required")
            .MinimumLength(6).WithMessage("Password must be at least 6 characters");
    }
}
