using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarImageValidator : AbstractValidator<CarImage>
    {
        public CarImageValidator()
        {
            //RuleFor(c => c.ImageName).Must(IfImageNameEmpty).WithMessage("Bu arabaya ait resim bulunamadı. Varsayılan resim atanmıştır.");
            RuleFor(c => c.ImageName).Must(StartingNameNotUse).WithMessage("Fotoğrafa 'ReCap' ön ekiyle başlayan bir isim oluşturunuz!");
            RuleFor(c => c.Date)
            .NotNull() // Tarih alanının null olmadığını kontrol eder.
            .WithMessage("Tarih alanı boş bırakılamaz.");
            {
                RuleFor(c => c.Date).UseCurrentTime();
            });

        }

        //private bool IfImageNameEmpty(CarImage carImage)
        //{
        //    if (carImage.ImageName==null)
        //    {
        //        carImage.ImageName = "ReCap-DefaultImage.png";
        //    }
        //}

        private bool StartingNameNotUse(string arg)
        {
            string requiredPrefix = "ReCap-";

            return arg.StartsWith(requiredPrefix);
        }
    }
}
