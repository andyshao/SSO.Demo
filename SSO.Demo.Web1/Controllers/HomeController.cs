﻿using Microsoft.AspNetCore.Mvc;

namespace SSO.Demo.Web1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LogOn()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}