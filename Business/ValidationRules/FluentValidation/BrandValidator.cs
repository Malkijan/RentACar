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
    public class BrandValidator:AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(brand => brand.Name).MinimumLength(2).WithMessage(Messages.BrandNameInvalid);
            RuleFor(brand => brand.Name).NotEmpty().WithMessage(Messages.BrandNameNotEmpty);
        }
    }
}
