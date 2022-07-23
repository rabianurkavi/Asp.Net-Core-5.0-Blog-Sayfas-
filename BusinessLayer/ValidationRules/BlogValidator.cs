using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator:AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog başlığını boş geçemezsiniz.");
            RuleFor(x => x.BlogTitle).MaximumLength(40).WithMessage("En fazla 40 karakter girişi yapabilirsiniz.");
            RuleFor(x => x.BlogTitle).MinimumLength(4).WithMessage("En az 4 karakter girişi yapabilirsiniz.");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog içeriğini boş geçemezsiniz.");
            RuleFor(x => x.BlogContent).MaximumLength(150).WithMessage("En fazla 150 karakter girişi yapabilirsiniz.");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog görselini boş geçemezsiniz.");
        }
    }
}
