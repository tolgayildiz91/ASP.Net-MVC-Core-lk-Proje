﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class ProductValidation:AbstractValidator<Product>
    {
        public ProductValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ürün Adını Boş Geçemezsiniz");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Ürün Adı En Az 3 Karakter Olmalıdır.");
            RuleFor(x => x.Stock).NotEmpty().WithMessage("Stok Sayısı Boş Geçilemez");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat Boş Geçilemez");
        }
    }
}
