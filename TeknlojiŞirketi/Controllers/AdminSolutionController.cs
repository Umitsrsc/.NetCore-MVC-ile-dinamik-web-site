using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using TeknlojiŞirketi.Concrete;
using TeknlojiŞirketi.EntityFrameworkCore;
using TeknlojiŞirketi.Models;
using TeknlojiŞirketi.Validation;

namespace TeknlojiŞirketi.Controllers
{
    public class AdminSolutionController : Controller
    {
        SolutionManager sm = new SolutionManager(new EFSolutionDal());
        public IActionResult Index()
        {
            var solutionValues = sm.GetList();
            return View(solutionValues);
        }
        [HttpGet]
        public ActionResult AddSolution()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSolution(Solution s)
        {
            SolutionValidator solutionValidator = new SolutionValidator();
            ValidationResult results = solutionValidator.Validate(s);
            if (results.IsValid)
            {
                sm.SolutionAdd(s);
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
        public ActionResult DeleteSolution(int id)
        {
            var solutionvalue = sm.GetById(id);
            sm.SolutionDelete(solutionvalue);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditSolution(int id)
        {
            var solutionvalue = sm.GetById(id);
            return View(solutionvalue);
        }
        [HttpPost]
        public ActionResult EditSolution(Solution s)
        {
            sm.SolutionUpdate(s);
            return RedirectToAction("Index");
        }
    }
}
