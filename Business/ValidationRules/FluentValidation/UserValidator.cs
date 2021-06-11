using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Constants;
using Core.Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
   public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(user => user.FirstName).NotEmpty().WithMessage(Messages.UserNameError);
            RuleFor(user => user.FirstName).NotNull().WithMessage(Messages.UserNameError);
            RuleFor(user => user.FirstName).MinimumLength(2).WithMessage(Messages.UserNameError);
            RuleFor(user => user.FirstName).MaximumLength(20).WithMessage(Messages.UserNameError);

            RuleFor(user => user.LastName).NotEmpty().WithMessage(Messages.UserNameError);
            RuleFor(user => user.LastName).NotNull().WithMessage(Messages.UserNameError);
            RuleFor(user => user.LastName).MinimumLength(2).WithMessage(Messages.UserNameError);
            RuleFor(user => user.LastName).MaximumLength(20).WithMessage(Messages.UserNameError);

            RuleFor(user => user.Email).NotEmpty().WithMessage(Messages.UserEmailInvalid);
            RuleFor(user => user.Email).NotNull().WithMessage(Messages.UserEmailInvalid);
            RuleFor(user => user.Email).EmailAddress().WithMessage(Messages.UserEmailInvalid);


        }
    }
}
