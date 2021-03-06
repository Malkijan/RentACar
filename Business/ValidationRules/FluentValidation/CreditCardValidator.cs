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
    public class CreditCardValidator : AbstractValidator<CreditCard>
    {
        public CreditCardValidator()
        {
            RuleFor(creditCard => creditCard.CustomerId).NotNull();
            RuleFor(creditCard => creditCard.CustomerId).NotEmpty();

            RuleFor(creditCard => creditCard.CardholderName).NotNull();
            RuleFor(creditCard => creditCard.CardholderName).NotEmpty();
            RuleFor(creditCard => creditCard.CardholderName).MaximumLength(20).WithMessage(Messages.CreditCardNameLimitReached);

            RuleFor(creditCard => creditCard.CardNumber).NotNull();
            RuleFor(creditCard => creditCard.CardNumber).NotEmpty();
            RuleFor(creditCard => creditCard.CardNumber).MinimumLength(19).WithMessage(Messages.CreditCardNumberInvalid);
            RuleFor(creditCard => creditCard.CardNumber).MaximumLength(20).WithMessage(Messages.CreditCardNumberInvalid);

            RuleFor(creditCard => creditCard.CVV).NotNull();
            RuleFor(creditCard => creditCard.CVV).NotEmpty();
            RuleFor(creditCard => creditCard.CVV).Length(3).WithMessage(Messages.CreditCardCVVNumberInvalid);

            RuleFor(creditCard => creditCard.ExpirationDate).NotNull();
            RuleFor(creditCard => creditCard.ExpirationDate).NotEmpty();

        }
    }
}
