using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TeknlojiŞirketi.Abstract;

namespace TeknlojiŞirketi.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {

        DinamikWebContext c = new DinamikWebContext();
        DbSet<T> _object;
        public GenericRepository()
        {
            _object = c.Set<T>();
        }
        public void Delete(T p)
        {
            var deletedEntity=c.Entry(p);
            deletedEntity.State= EntityState.Deleted;
            //_object.Remove(p);
            c.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);
        }

        public void Insert(T p)
        {
            var addedEntity=c.Entry(p);
            addedEntity.State= EntityState.Added;
            //_object.Add(p);
            c.SaveChanges();
        }

        public List<T> List()
        {

            return _object.ToList();
        }
        public List<T> List(Expression<Func<T, bool>> Filter)
        {
            return _object.Where(Filter).ToList();
        }

        public void Update(T p)
        {
            var updatedEntity = c.Entry(p);
            updatedEntity.State = EntityState.Modified;
            c.SaveChanges();
        }
    }
}
