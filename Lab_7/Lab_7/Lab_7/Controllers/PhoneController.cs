using System;
using System.Linq;
using System.Web.Mvc;

namespace Lab_7.Controllers
{
    public class PhoneController : Controller
    {
        Models.PersonContext context = new Models.PersonContext();

        [HttpGet]
        public ActionResult Index()
        {
            return View("Index", context.Persons.AsEnumerable());
        }

        [HttpGet]
        public ActionResult Add()
        {
            Models.Person person = new Models.Person();
            person.BDay = DateTime.Now.AddYears(-18);
            return View("Add", person);
        }

        [HttpPost]
        public ActionResult Add(Models.Person person)
        {
            try
            {
                if (person.BDay < DateTime.Now.AddYears(-120))
                {
                    ModelState.AddModelError("BDay", "Значение даты не может быть меньше текущей, больше чем на 120 лет");
                }
                if (ModelState.IsValid)
                {
                    context.Persons.Add(person);
                    context.SaveChanges();
                    return RedirectToAction("Index", context.Persons.AsEnumerable());
                }
                return View(person);
            }
            catch
            {
                return View("Index", context.Persons.AsEnumerable());
            }
        }

        [HttpGet]
        public ActionResult Update(string phone)
        {
            Models.Person person = context.Persons.Find(phone);
            return View("Update", person);
        }

        [HttpPost]
        public ActionResult Update(Models.Person person)
        {
            try
            {
                if (person.BDay < DateTime.Now.AddYears(-120))
                {
                    ModelState.AddModelError("BDay", "Значение даты не может быть меньше текущей, больше чем на 120 лет");
                }
                if (ModelState.IsValid)
                {
                    context.Entry(person).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                    return RedirectToAction("Index", context.Persons.AsEnumerable());
                }
                return View(person);
            }
            catch
            {
                return View("Index", context.Persons.AsEnumerable());
            }
        }

        [HttpGet]
        public ActionResult Delete(string phone)
        {
            try
            {
                Models.Person person = context.Persons.Find(phone);
                if (person != null)
                {
                    context.Persons.Remove(person);
                }
                context.SaveChanges();
                return RedirectToAction("Index", context.Persons.AsEnumerable());
            }
            catch
            {
                return View("Index", context.Persons.AsEnumerable());
            }
        }
    }
}