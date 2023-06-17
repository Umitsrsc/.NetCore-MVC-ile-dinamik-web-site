using TeknlojiŞirketi.Models;

namespace TeknlojiŞirketi.Abstract
{
    public interface IMessageService
    {
        List<Message> GetListInbox();
        List<Message> GetListSendbox();
        void MessageAdd(Message message);
        Message GetById(int id);
        void MessageDelete(Message message);
        void MessageUpdate(Message message);
    }
}
