using Microsoft.AspNetCore.Mvc;
using TeknlojiŞirketi.Concrete;
using TeknlojiŞirketi.Models;

namespace TeknlojiŞirketi.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Admin p)
        {
            DinamikWebContext c= new DinamikWebContext();
            var adminuserinfo=c.Admins.FirstOrDefault(x=>x.AdminUserName==p.AdminUserName&& x.AdminPassword==p.AdminPassword);
            if (adminuserinfo!=null)
            {
              
                return RedirectToAction("Index", "AdminCurrentOpening");
            }
            else
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
