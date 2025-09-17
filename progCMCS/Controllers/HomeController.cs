using Microsoft.AspNetCore.Mvc;

namespace progCMCS.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
