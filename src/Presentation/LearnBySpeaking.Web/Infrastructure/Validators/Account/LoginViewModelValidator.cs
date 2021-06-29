using FluentValidation;
using LearnBySpeaking.Web.Models.ViewModels.Account;

namespace LearnBySpeaking.Web.Infrastructure.Validators.Account
{
    public class LoginViewModelValidator : AbstractValidator<LoginViewModel>
    {
        public LoginViewModelValidator()
        {
            RuleFor(x => x.UserName)
                .NotEmpty()
                .Length(5, 30);

            RuleFor(x => x.Password)
                .NotEmpty()
                .Length(6, 30);
        }
    }
}