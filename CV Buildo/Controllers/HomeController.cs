using Microsoft.AspNetCore.Mvc;
using CVBuildo.Models;
using System.Diagnostics;

namespace CVBuildo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new ResumeData());
        }

        [HttpPost]
        public IActionResult Index(ResumeData model)
        {
            return View(model);
        }

        public IActionResult AtsChecker()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Terms()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }
    }
}