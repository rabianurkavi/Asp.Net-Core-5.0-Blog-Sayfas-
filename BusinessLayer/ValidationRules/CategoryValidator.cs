using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("20 karakterden fazla giriş yapamazsınız.");
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori ismi boş geçilemez.");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("3 karakterden az giriş yapamazsınız.");
            RuleFor(x => x.CategoryDescription).MaximumLength(200).WithMessage("Max karakter sayısı aşıldı.Lütfen 200 ve daha az karakter girişi yapınız.");
        }
    }
}
