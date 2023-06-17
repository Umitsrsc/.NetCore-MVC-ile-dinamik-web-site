using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TeknlojiŞirketi.Concrete;
using TeknlojiŞirketi.EntityFrameworkCore;
using TeknlojiŞirketi.Models;
using TeknlojiŞirketi.Validation;

namespace TeknlojiŞirketi.Controllers
{
    public class AdminCurrentOpeningController : Controller
    {
        
        CurrentOpeningManager cm = new CurrentOpeningManager(new EFCurrentOpeningDal());
        //[Authorize]
        public IActionResult Index()
        {
            var openinValues = cm.GetList();
            return View(openinValues);
        }
        [HttpGet]
        public ActionResult AddOpening()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddOpening(CurrentOpening p)
        {
            CurrentOpeningValidator openingValidator= new CurrentOpeningValidator();
            ValidationResult results=openingValidator.Validate(p);
            if (results.IsValid)
            {
                cm.CurrentOpeningAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public ActionResult DeleteOpening(int id)
        {
            var openingvalue=cm.GetById(id);
            cm.OpeningDelete(openingvalue);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditOpening(int id)
        {
            var openingvalue = cm.GetById(id);
            return View(openingvalue);
        }
        [HttpPost]
        public ActionResult EditOpening(CurrentOpening p)
        {
            cm.OpeningUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
