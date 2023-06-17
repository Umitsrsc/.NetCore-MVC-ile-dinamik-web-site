using TeknlojiŞirketi.Models;

namespace TeknlojiŞirketi.Abstract
{
    public interface ICurrentOpeningService
    {
        List<CurrentOpening> GetList();
        void CurrentOpeningAdd(CurrentOpening currentOpening);
        CurrentOpening GetById(int id);
        void OpeningDelete(CurrentOpening currentOpening);
        void OpeningUpdate(CurrentOpening currentOpening);
    }
}
