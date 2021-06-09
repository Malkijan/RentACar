using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator:AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(rental => rental.CustomerId).NotEmpty();
            RuleFor(rental => rental.CarId).NotEmpty();
            RuleFor(rental => rental.ReturnDate).NotNull();
            RuleFor(rental => rental.ReturnDate).GreaterThanOrEqualTo(r => r.RentDate).When(r => r.ReturnDate.HasValue);
        }
    }
}
