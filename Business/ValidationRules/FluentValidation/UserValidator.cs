using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
   public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(user => user.FirstName).NotEmpty();
            RuleFor(user => user.FirstName).NotNull();
            RuleFor(user => user.FirstName).MinimumLength(2);
            RuleFor(user => user.FirstName).MaximumLength(20);

            RuleFor(user => user.LastName).NotEmpty();
            RuleFor(user => user.LastName).NotNull();
            RuleFor(user => user.LastName).MinimumLength(2);
            RuleFor(user => user.LastName).MaximumLength(20);

            RuleFor(user => user.Email).NotEmpty();
            RuleFor(user => user.Email).NotNull();
            RuleFor(user => user.Email).EmailAddress();


        }
    }
}
