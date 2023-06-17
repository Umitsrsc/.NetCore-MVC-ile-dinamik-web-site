using TeknlojiŞirketi.Abstract;
using TeknlojiŞirketi.Concrete.Repositories;
using TeknlojiŞirketi.Models;

namespace TeknlojiŞirketi.EntityFrameworkCore
{
    public class EFMessageDal : GenericRepository<Message>, IMessageDal
    {
    }
}
