using TeknlojiŞirketi.Models;

namespace TeknlojiŞirketi.Abstract
{
    public interface INewsService
    {
        List<News> GetList();
        void NewsAdd(News news);
        News GetById(int id);
        void NewsDelete(News news);
        void NewsUpdate(News news);
    }
}
