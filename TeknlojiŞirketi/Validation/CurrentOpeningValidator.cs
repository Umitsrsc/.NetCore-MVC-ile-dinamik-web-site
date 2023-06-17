using FluentValidation;
using TeknlojiŞirketi.Models;

namespace TeknlojiŞirketi.Validation
{
    public class CurrentOpeningValidator:AbstractValidator<CurrentOpening>
    {
        public CurrentOpeningValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Pozisyon adını boş geçemezsiniz !");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("En az 3 karakter giriniz !");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklamayı boş geçemezsiniz !");
            RuleFor(x => x.Location).NotEmpty().WithMessage("Konumu boş geçemezsiniz !");
        }
    }
}
