using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TeknlojiŞirketi.Abstract;
using TeknlojiŞirketi.Models;

namespace TeknlojiŞirketi.Concrete.Repositories
{
    public class CurrentOpeningRepository : ICurrentOpeningDal
    {
        DinamikWebContext c = new DinamikWebContext();
        DbSet <CurrentOpening>_object;
        public void Delete(CurrentOpening p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public CurrentOpening Get(Expression<Func<CurrentOpening, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(CurrentOpening p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public List<CurrentOpening> List()
        {
            return _object.ToList();
        }

        public List<CurrentOpening> List(Expression<Func<CurrentOpening, bool>> Filter)
        {
            throw new NotImplementedException();
        }

        public void Update(CurrentOpening p)
        {
            c.SaveChanges();
        }
    }
}
