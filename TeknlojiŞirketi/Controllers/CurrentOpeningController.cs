using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using TeknlojiŞirketi.Concrete;
using TeknlojiŞirketi.EntityFrameworkCore;
using TeknlojiŞirketi.Models;
using TeknlojiŞirketi.Validation;

namespace TeknlojiŞirketi.Controllers
{
    public class CurrentOpeningController : Controller
    {
        CurrentOpeningManager Opening = new CurrentOpeningManager(new EFCurrentOpeningDal());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetOpeningList()
        {
            var OpeningValues = Opening.GetList();
            return View(OpeningValues);
        }
        [HttpGet]
        public IActionResult AddOpening()
        {

            return View();

        }
        [HttpPost]
        public IActionResult AddOpening(CurrentOpening p)
        {
            //Opening.OpeningAdd(p);
            CurrentOpeningValidator currentOpeningValidator = new CurrentOpeningValidator();
            ValidationResult result = currentOpeningValidator.Validate(p);
            if (result.IsValid)
            {
                Opening.CurrentOpeningAdd(p);
                return RedirectToAction("GetOpeningList");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();

        }
    }
}
