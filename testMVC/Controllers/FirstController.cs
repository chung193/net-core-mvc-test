using Microsoft.AspNetCore.Mvc;
using testMVC.Models;

namespace testMVC.Controllers
{
    public class FirstController : Controller
    {
        public string Index()
        {
            return "Hello world";
        }

        public IActionResult Hello()
        {
            ViewBag.Message = "Hello World";
            return View();
        }

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
            Respository.Create(person);
            return View("Thanks", person);
        }
    }
}
