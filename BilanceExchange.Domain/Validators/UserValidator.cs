using Bilance_Exchange.Domain.Entity;
using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bilance_Exchange.Domain.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(user => user.Name)
                .NotEmpty();
            RuleFor(user => user.Email)
                .NotEmpty()
                .EmailAddress(EmailValidationMode.Net4xRegex);
            RuleFor(user => user.Password)
                .NotEmpty()
                .MinimumLength(8);
            RuleFor(user => user.UserTypeId)
                .NotNull();
        }
    }
}
