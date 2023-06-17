using FluentValidation;
using TeknlojiŞirketi.Models;

namespace TeknlojiŞirketi.Validation
{
    public class MessageValidator : AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Alıcı Adresini boş geçemezsiniz !");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konuyu boş geçemezsiniz !");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesajı boş geçemezsiniz !");
            //RuleFor(x => x.ReceiverMail).MinimumLength(30).WithMessage("En az 30 karakter giriniz !");
            RuleFor(x => x.MessageContent).MinimumLength(30).WithMessage("En az 30 karakter giriniz !");
        }
    }
    
}
