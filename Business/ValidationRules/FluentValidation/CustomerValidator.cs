using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Constants;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator:AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(customer => customer.CompanyName).NotEmpty().WithMessage(Messages.CustomerCompanyNameNotEmpty);
            RuleFor(customer => customer.CompanyName).MinimumLength(3).WithMessage(Messages.CustomerCompanyNameInvalid);
            RuleFor(customer => customer.UserId).NotNull();
        }
    }
}
