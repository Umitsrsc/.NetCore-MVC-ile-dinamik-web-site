using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using TeknlojiŞirketi.Concrete;
using TeknlojiŞirketi.EntityFrameworkCore;
using TeknlojiŞirketi.Models;
using TeknlojiŞirketi.Validation;

namespace TeknlojiŞirketi.Controllers
{
    public class MessageController : Controller
    {
        MessageManager mm = new MessageManager(new EFMessageDal());
        MessageValidator messagevalidator= new MessageValidator();
        public IActionResult Inbox()
        {
            var messagelist = mm.GetListInbox();
            return View(messagelist);
        }
        public IActionResult Sendbox()
        {
            var messagelist = mm.GetListSendbox();
            return View(messagelist);
        }
        public IActionResult GetInboxMessageDetails(int id)
        {
            var values = mm.GetById(id);
            return View(values);
        }
        public IActionResult GetSendboxMessageDetails(int id)
        {
            var values = mm.GetById(id);
            return View(values);
        }
        [HttpGet]
        public IActionResult NewMessage() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult NewMessage(Message p)
        {

            ValidationResult result = messagevalidator.Validate(p);
            if (result.IsValid)
            {
                p.MessageDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                mm.MessageAdd(p);
                return RedirectToAction("Sendbox");
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
