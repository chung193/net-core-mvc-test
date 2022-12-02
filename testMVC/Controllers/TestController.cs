using Microsoft.AspNetCore.Mvc;
using testMVC.Models;
using testMVC.Common;

namespace testMVC.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            List<Item> items = XuLyDuLieu.loadJson();
            ViewBag.items = items;
            return View();
        }
    }
}
