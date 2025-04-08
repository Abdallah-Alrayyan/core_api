using Microsoft.AspNetCore.Mvc;

namespace examples.Server.Controllers
{
    public class Home : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
