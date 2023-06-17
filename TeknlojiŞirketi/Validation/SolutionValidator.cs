using FluentValidation;
using TeknlojiŞirketi.Models;
namespace TeknlojiŞirketi.Validation
{

    public class SolutionValidator : AbstractValidator<Solution>
    {
        public SolutionValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Pozisyon adını boş geçemezsiniz !");
            RuleFor(x => x.Title).MinimumLength(3).WithMessage("En az 3 karakter giriniz !");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklamayı boş geçemezsiniz !");
            //RuleFor(x => x.Location).NotEmpty().WithMessage("Konumu boş geçemezsiniz !");
        }

    }
}
