﻿using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SSO.Demo.Service;
using SSO.Demo.Web1.Model;

namespace SSO.Demo.Web1.Controllers
{
    public class UserController : Controller
    {
        private readonly SkyChenContext _skyChenContext;

        public UserController(SkyChenContext skyChenContext)
        {
            _skyChenContext = skyChenContext;
        }

        public IActionResult Index()
        {
            var userList = _skyChenContext.User.ToList();
            return View(userList);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(UserParams userParams)
        {
            var user = new User
            {
                CreateDateTime = DateTime.Now,
                UserId = Guid.NewGuid().ToString("N"),
                Password = userParams.Password,
                UserName = userParams.UserName
            };

            _skyChenContext.User.Add(user);
            _skyChenContext.SaveChanges();

            return View("Index");
        }
    }
}