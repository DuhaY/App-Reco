using Microsoft.AspNetCore.Mvc;

namespace GameRecomWebProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
