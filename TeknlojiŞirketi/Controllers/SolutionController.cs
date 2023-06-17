using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using TeknlojiŞirketi.Concrete;
using TeknlojiŞirketi.EntityFrameworkCore;
using TeknlojiŞirketi.Models;
using TeknlojiŞirketi.Validation;

namespace TeknlojiŞirketi.Controllers
{
    
    public class SolutionController : Controller
    {
        SolutionManager solution = new SolutionManager(new EFSolutionDal());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetSolutionList()
        {
            var SolutionValues = solution.GetList();
            return View(SolutionValues);
        }
        [HttpGet]
        public IActionResult AddSolution()
        {

            return View();

        }
        [HttpPost]
        public IActionResult AddSolution(Solution p)
        {
            //Opening.OpeningAdd(p);
            SolutionValidator solutionValidator = new SolutionValidator();
            ValidationResult result = solutionValidator.Validate(p);
            if (result.IsValid)
            {
                solution.SolutionAdd(p);
                return RedirectToAction("GetSolutionList");
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
