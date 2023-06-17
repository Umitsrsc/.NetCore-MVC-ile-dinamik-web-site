using TeknlojiŞirketi.Abstract;
using TeknlojiŞirketi.Concrete.Repositories;
using TeknlojiŞirketi.Models;

namespace TeknlojiŞirketi.Concrete
{
    public class CurrentOpeningManager : ICurrentOpeningService
    {


        ICurrentOpeningDal _openingdal;

        public CurrentOpeningManager(ICurrentOpeningDal openingdal)
        {
            _openingdal = openingdal;
        }

        public void CurrentOpeningAdd(CurrentOpening currentOpening)
        {
             _openingdal.Insert(currentOpening);
        }

        public CurrentOpening GetById(int id)
        {
            return _openingdal.Get(x=>x.Id==id);
        }

        public List<CurrentOpening> GetList()
        {
            return _openingdal.List();
        }

        public void OpeningDelete(CurrentOpening currentOpening)
        {
            _openingdal.Delete(currentOpening);
        }

        public void OpeningUpdate(CurrentOpening currentOpening)
        {
            _openingdal.Update(currentOpening);
        }

        //public void CurrentOpeningAdd(CurrentOpening p)
        //{
        //    if (p.Name==""||p.Name.Length<=2)
        //    {
        //        //Hata mesajı
        //    }
        //    else
        //    {
        //        _openingdal.Insert(p);
        //    }
        //}
    }
}
