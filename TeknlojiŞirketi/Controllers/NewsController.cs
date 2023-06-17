using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using TeknlojiŞirketi.Concrete;
using TeknlojiŞirketi.EntityFrameworkCore;
using TeknlojiŞirketi.Models;
using TeknlojiŞirketi.Validation;

namespace TeknlojiŞirketi.Controllers
{
    public class NewsController : Controller
    {
        NewsManager nm = new NewsManager(new EFNewsDal());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetNewsList()
        {
            var NewsValues = nm.GetList();
            return View(NewsValues);
        }
        [HttpGet]
        public IActionResult AddNews()
        {

            return View();

        }
        [HttpPost]
        public IActionResult AddNews(News p)
        {
            //Opening.OpeningAdd(p);
            NewsValidator newsValidator = new NewsValidator();
            ValidationResult result = newsValidator.Validate(p);
            if (result.IsValid)
            {
                nm.NewsAdd(p);
                return RedirectToAction("GetNewsList");
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
