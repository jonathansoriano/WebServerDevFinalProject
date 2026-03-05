using Microsoft.AspNetCore.Mvc;
using WebServerDevFinalProject.Models;

namespace WebServerDevFinalProject.Controllers
{
    public class JonController : Controller
    {
        private HobbyContext context { get; set; }

        public JonController(HobbyContext ctx)
        {
            context = ctx;
        }
        public IActionResult AboutMe()
        {
            return View();
        }

        public IActionResult HobbyList()
        {
            var jonsHobbies = context.Jon.OrderBy(hobby => hobby.HobbyName).ToList();
            return View(jonsHobbies);
        }
    }
}
