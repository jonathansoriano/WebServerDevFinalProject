using Microsoft.AspNetCore.Mvc;
using WebServerDevFinalProject.Models;

namespace WebServerDevFinalProject.Controllers
{
    public class ChristopherController : Controller
    {
        private HobbyContext context { get; set; }

        public ChristopherController(HobbyContext ctx)
        {
            context = ctx;
        }

        public IActionResult AboutMe()
        {
            return View();
        }

        public IActionResult HobbyList()
        {
            var christopherHobbies = context.Christopher
                .OrderBy(hobby => hobby.HobbyName)
                .ToList();

            return View(christopherHobbies);
        }
    }
}
