using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TeknlojiŞirketi.Concrete;
using TeknlojiŞirketi.EntityFrameworkCore;

namespace TeknlojiŞirketi.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        SolutionManager sm = new SolutionManager(new EFSolutionDal());
        public IActionResult Solutions()
        {
            var solutionlist = sm.GetList();
            return View(solutionlist);
        }
        public PartialViewResult Index(int id=0)
        {
            var solutionlist = sm.GetListById(id);
            return PartialView(solutionlist);
        }
    }
}
