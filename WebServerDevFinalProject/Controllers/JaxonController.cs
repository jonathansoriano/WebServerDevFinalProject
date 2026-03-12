using Microsoft.AspNetCore.Mvc;
using WebServerDevFinalProject.Models;

namespace WebServerDevFinalProject.Controllers
{
    public class JaxonController : Controller
    {

        private HobbyContext context { get; set; }

        public JaxonController(HobbyContext ctx)
        {
            context = ctx;
        }
        public IActionResult AboutMe()
        {
            return View();
        }

        public IActionResult HobbyList()
        {
            var jaxonsHobbies = context.Jaxon.OrderBy(hobby => hobby.HobbyName).ToList();
            return View(jaxonsHobbies);
        }
    }
}