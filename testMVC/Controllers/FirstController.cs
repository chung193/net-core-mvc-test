using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.Mvc;
using testMVC.Models;

namespace testMVC.Controllers
{
    public class FirstController : Controller
    {

        public IActionResult Info()
        {
            Person person = new Person();
            person.Name = "John";
            person.Age = 29;
            person.Location = "United States";
            return View(person);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {
            if (ModelState.IsValid)
            {
                Repository.Create(person);
                return View("Thanks", person);
            }
            else
            {
                return View();
            }
            
        }

        public IActionResult Index()
        {
            return View(Repository.AllPersons);
        }

        public IActionResult Update(string empname)
        {
            Person person = Repository.AllPersons.Where(e => e.Name == empname).FirstOrDefault();
            return View(person);
        }

        [HttpPost]
        public IActionResult Update(Person person, string empname)
        {
            if (ModelState.IsValid)
            {
                Repository.AllPersons.Where(e => e.Name == empname).FirstOrDefault().Name = person.Name;
                Repository.AllPersons.Where(e => e.Name == empname).FirstOrDefault().Age = person.Age;
                Repository.AllPersons.Where(e => e.Name == empname).FirstOrDefault().Location = person.Location;
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public IActionResult Delete(string empname) { 
            Person person = Repository.AllPersons.Where(e=> e.Name == empname).FirstOrDefault();
            Repository.Delete(person);
            return RedirectToAction("Index");
        }
    }
}
