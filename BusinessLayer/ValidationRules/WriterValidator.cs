using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı soyadı kısmı boş geçilemez.");
            RuleFor(x=>x.WriterMail).NotEmpty().WithMessage("Yazar mail kısmı boş geçilemez.");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Parola boş geçilemez.");
            RuleFor(x => x.WriterPassword).MaximumLength(12).WithMessage("Parolanız en fazla 12 karakter olmalı");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişii yapın.");
            RuleFor(x => x.WriterName).MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter girişi yapın.");
            RuleFor(x => x.WriterPassword).Must(IsPasswordValid).WithMessage("Parolanız en az sekiz karakter,en az bir büyük harf, bir küçük harf ve bir sayı içermelidir.");
            RuleFor(x => x.WriterMail).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter girişi yapın.");
        }
        private bool IsPasswordValid(string arg)
        {
            Regex regex=new Regex(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)[A-Za-z\d]{8,}$");
            return regex.IsMatch(arg);
        }
    }
}
