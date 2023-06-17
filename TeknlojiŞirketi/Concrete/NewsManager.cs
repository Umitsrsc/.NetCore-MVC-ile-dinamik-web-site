using TeknlojiŞirketi.Abstract;
using TeknlojiŞirketi.Models;

namespace TeknlojiŞirketi.Concrete
{
    public class NewsManager : INewsService
    {
        INewsDal _newsDal;

        public NewsManager(INewsDal newsDal)
        {
            _newsDal = newsDal;
        }

        public News GetById(int id)
        {
            return _newsDal.Get(x=>x.Id==id);
        }

        public List<News> GetList()
        {
            return _newsDal.List();
        }

        public void NewsAdd(News news)
        {
            _newsDal.Insert(news);
        }

        public void NewsDelete(News news)
        {
            _newsDal.Delete(news);
        }

        public void NewsUpdate(News news)
        {
            _newsDal.Update(news);
        }
    }
}
