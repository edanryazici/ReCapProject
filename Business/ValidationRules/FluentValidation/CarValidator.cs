﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator: AbstractValidator<Car>
    {
        public CarValidator()
        {

            RuleFor(p => p.CarName).NotEmpty();
            RuleFor(p => p.CarName).MinimumLength(2);
            RuleFor(p => p.DailyPrice).NotEmpty();
            RuleFor(p => p.DailyPrice).GreaterThan(0);
            RuleFor(p => p.DailyPrice).GreaterThanOrEqualTo(10).When(prop => prop.BrandId == 1);
            RuleFor(p => p.CarName).Must(StartWithA).WithMessage("Ürünlerin Adı A Harfi İle Başlamalı!"); //kendi kuralımızı yazarsak ampulden generic yaptık
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
