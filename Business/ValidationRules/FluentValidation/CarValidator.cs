using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(x => x.BrandId).NotEmpty().NotNull();
            RuleFor(x => x.ColorId).NotEmpty().NotNull();
            RuleFor(x => x.BrandId).GreaterThan(0);
            RuleFor(x => x.ColorId).GreaterThan(0);
        }
    }
}
