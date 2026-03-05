using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebServerDevFinalProject.Models;

namespace WebServerDevFinalProject.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
