using TeknlojiŞirketi.Models;

namespace TeknlojiŞirketi.Abstract
{
    public interface IContactService
    {
        List<Contact> GetList();
        void ContactAdd(Contact contact);
        Contact GetById(int id);
        void ContactDelete(Contact contact);
        void ContactUpdate(Contact contact);
    }
}
