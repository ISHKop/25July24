﻿using Microsoft.AspNetCore.Mvc;

namespace MyFristWebApp.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }
    }
}
