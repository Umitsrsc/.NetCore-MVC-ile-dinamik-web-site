using FluentValidation;
using TeknlojiŞirketi.Models;
using TeknlojiŞirketi.Concrete;

namespace TeknlojiŞirketi.Validation
{
    public class ContactValidator:AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Kullanıcı adını boş geçemezsiniz !");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("En az 3 karakter giriniz !");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Açıklamayı boş geçemezsiniz !");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Mail adresini boş geçemezsiniz !");
            RuleFor(x => x.Phone).NotEmpty().WithMessage("Telefon numarasını boş geçemezsiniz !");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu başlığını boş geçemezsiniz !");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("En az 3 karakter giriniz !");
            RuleFor(x => x.Message).NotEmpty().WithMessage("Mesajı boş geçemezsiniz !");
            RuleFor(x => x.Message).MinimumLength(30).WithMessage("En az 30 karakter giriniz !");
        }
    }
}
