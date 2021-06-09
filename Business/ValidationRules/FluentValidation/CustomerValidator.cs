﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator:AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(customer => customer.CompanyName).NotEmpty();
            RuleFor(customer => customer.CompanyName).MinimumLength(3);
            RuleFor(customer => customer.UserId).NotNull();
        }
    }
}
