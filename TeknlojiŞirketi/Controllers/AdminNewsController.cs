using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using TeknlojiŞirketi.Concrete;
using TeknlojiŞirketi.EntityFrameworkCore;
using TeknlojiŞirketi.Models;
using TeknlojiŞirketi.Validation;

namespace TeknlojiŞirketi.Controllers
{
    public class AdminNewsController : Controller
    {
        NewsManager nm = new NewsManager(new EFNewsDal());
        public IActionResult Index()
        {
            var newsValues = nm.GetList();
            return View(newsValues);
        }
        [HttpGet]
        public ActionResult AddNews()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNews(News p)
        {
            NewsValidator newsValidator = new NewsValidator();
            ValidationResult results = newsValidator.Validate(p);
            if (results.IsValid)
            {
                nm.NewsAdd(p);
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
        public ActionResult DeleteNews(int id)
        {
            var newsvalue = nm.GetById(id);
            nm.NewsDelete(newsvalue);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditNews(int id)
        {
            var newsvalue = nm.GetById(id);
            return View(newsvalue);
        }
        [HttpPost]
        public ActionResult EditNews(News p)
        {
            nm.NewsUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
