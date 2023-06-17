using Microsoft.AspNetCore.Mvc;
using TeknlojiŞirketi.Concrete;
using TeknlojiŞirketi.EntityFrameworkCore;
using TeknlojiŞirketi.Validation;

namespace TeknlojiŞirketi.Controllers
{
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EFContactDal());
        ContactValidator cv= new ContactValidator();
        public IActionResult Index()
        {
            var contactvalues = cm.GetList();
            return View(contactvalues);
        }
        public IActionResult GetContactDetails(int id)
        {
            var contactvalues = cm.GetById(id);
            return View(contactvalues);
        }
    }
}
