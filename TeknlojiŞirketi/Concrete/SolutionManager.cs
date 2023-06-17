using TeknlojiŞirketi.Abstract;
using TeknlojiŞirketi.Concrete.Repositories;
using TeknlojiŞirketi.Models;

namespace TeknlojiŞirketi.Concrete
{
    public class SolutionManager : ISolutionService
    {
        ISolutionDal _solutionDal;
        public SolutionManager(ISolutionDal solutionDal)
        {
            _solutionDal = solutionDal;
        }
        public Solution GetById(int id)
        {
            return _solutionDal.Get(x=>x.Id==id);
        }

        public List<Solution> GetList()
        {
            return _solutionDal.List();
        }

        public List<Solution> GetListById(int id)
        {
            return _solutionDal.List(x => x.Id == id);
        }

        public void SolutionAdd(Solution solution)
        {
            _solutionDal.Insert(solution);
        }

        public void SolutionDelete(Solution solution)
        {
            _solutionDal.Delete(solution);
        }

        public void SolutionUpdate(Solution solution)
        {
            _solutionDal.Update(solution);
        }
    }
}
