using Microsoft.AspNetCore.Mvc;

namespace Villla.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
