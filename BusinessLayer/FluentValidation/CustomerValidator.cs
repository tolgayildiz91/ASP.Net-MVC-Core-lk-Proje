using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir Bilgisi Boş Geçilemez");
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim Bilgisi Boş Geçilemez");

        }
    }
}
