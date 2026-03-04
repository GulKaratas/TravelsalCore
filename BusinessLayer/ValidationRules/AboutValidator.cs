using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator() { 
        RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama kısmı boş geçilemez.");
        RuleFor(x => x.Description).MinimumLength(10).WithMessage("Açıklama kısmı en az 10 karakter olmalıdır.");
            RuleFor(x => x.Description).MaximumLength(500).WithMessage("Açıklama kısmı en fazla 500 karakter olmalıdır.");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Görsel alanı boş geçilemez.");
        }
    }
}
