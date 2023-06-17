using TeknlojiŞirketi.Models;

namespace TeknlojiŞirketi.Abstract
{
    public interface ISolutionService
    {
        List<Solution> GetList();
        Solution GetById(int id);
        List<Solution> GetListById(int id);
        void SolutionAdd(Solution solution);
        void SolutionDelete(Solution solution);
        void SolutionUpdate(Solution solution);
    }
}
