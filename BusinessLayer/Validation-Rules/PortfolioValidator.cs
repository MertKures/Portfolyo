using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.Validation_Rules
{
    public class PortfolioValidator : AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Proje adı boş geçilemez");
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Proje adı en az 5 karakter olmalıdır");
            RuleFor(x => x.Name).MaximumLength(100).WithMessage("Proje adı en fazla 100 karakter olmalıdır");
            RuleFor(x => x.Platform).NotEmpty().WithMessage("Platform adı boş geçilemez");
            RuleFor(x => x.Platform).MinimumLength(3).WithMessage("Platform adı en az 3 karakter olmalıdır");
            RuleFor(x => x.Platform).MaximumLength(50).WithMessage("Platform adı en fazla 50 karakter olmalıdır");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Proje ilk resmi boş geçilemez");
            RuleFor(x => x.ImageUrl2).NotEmpty().WithMessage("Projenin ikinci resmi boş geçilemez");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Proje ek resmi boş geçilemez");
            RuleFor(x => x.Image2).NotEmpty().WithMessage("Proje ek resmi boş geçilemez");
            RuleFor(x => x.Image3).NotEmpty().WithMessage("Proje ek resmi boş geçilemez");
            RuleFor(x => x.Image4).NotEmpty().WithMessage("Proje ek resmi boş geçilemez");
            RuleFor(x => x.Value).NotEmpty().WithMessage("Proje değeri boş geçilemez");
            RuleFor(x => x.Value).GreaterThan(0).WithMessage("Proje değeri 0'a eşit veya 0'dan büyük olmalıdır");
            RuleFor(x => x.Value).LessThanOrEqualTo(100).WithMessage("Proje değeri 100'e eşit veya 100'den küçük olmalıdır");
        }
    }
}
