using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TeknlojiŞirketi.Concrete;
using TeknlojiŞirketi.EntityFrameworkCore;
using TeknlojiŞirketi.Models;
using TeknlojiŞirketi.Validation;

namespace TeknlojiŞirketi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        SolutionManager sm = new SolutionManager(new EFSolutionDal());
        NewsManager nm = new NewsManager(new EFNewsDal());
        CurrentOpeningManager co= new CurrentOpeningManager(new EFCurrentOpeningDal());
        AboutManager ab = new AboutManager(new EFAboutDal());
        ContactManager mm = new ContactManager(new EFContactDal());
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contact(Contact p)
        {

            p.DateTime = DateTime.Parse(DateTime.Now.ToShortDateString()); 
            mm.ContactAdd(p);
            return RedirectToAction("Index","Home");
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Solution()
        {
            var solution = sm.GetList();
            return View(solution);
        }
        public IActionResult Career()
        {
            var currentopening = co.GetList();
            return View(currentopening);
        }
        public IActionResult Abouts()
        {
            var about = ab.GetList();
            return View(about);
        }
        public IActionResult News()
        {
            var news = nm.GetList();
            return View(news);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}