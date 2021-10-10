using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(x => x.CarId).NotEmpty().NotNull(); 
            RuleFor(x => x.CustomerId).NotEmpty().NotNull();
            RuleFor(x => x.RentDate).NotEmpty().NotNull();
        }
    }
}
