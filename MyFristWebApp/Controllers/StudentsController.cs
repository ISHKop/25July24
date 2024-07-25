using Microsoft.AspNetCore.Mvc;

namespace MyFristWebApp.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
