using Microsoft.AspNetCore.Mvc;
using TeknlojiŞirketi.Concrete;
using TeknlojiŞirketi.EntityFrameworkCore;
using TeknlojiŞirketi.Models;

namespace TeknlojiŞirketi.Controllers
{
    public class AboutController : Controller
    {
        AboutManager abm = new AboutManager(new EFAboutDal());
        public ActionResult Index()
        {
            var aboutvalues = abm.GetList();
            return View(aboutvalues);
        }
        [HttpGet]
        public ActionResult AddAbout()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAbout(About p)
        {
            abm.AboutAdd(p);
            return RedirectToAction("Index");
        }
        public PartialViewResult AboutPartial()
        {
            return PartialView();
        }
    }
}
