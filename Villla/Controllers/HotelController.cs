using Microsoft.AspNetCore.Mvc;

namespace Villla.Controllers
{
    public class HotelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
