using TeknlojiŞirketi.Abstract;
using TeknlojiŞirketi.Concrete.Repositories;
using TeknlojiŞirketi.Models;

namespace TeknlojiŞirketi.EntityFrameworkCore
{
    public class EFContactDal : GenericRepository<Contact>, IContactDal
    {
    }
}
