using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PCVMurcorWebApp.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet, Route ("create")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost, Route ("create")]
        public IActionResult Create(CreatePostRequest post)
        {
            return View();
        }

        public class CreatePostRequest
        {
            public int UserId { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }
            public string Office { get; set; }
            public string ManagerName { get; set; }
            public bool IsManager { get; set; }
            public string UserStatus { get; set; }
        }
    }
}