using Microsoft.AspNetCore.Mvc;

namespace ProgLng.Controllers
{
    public class HtmlController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
