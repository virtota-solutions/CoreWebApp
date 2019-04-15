using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PCVMurcorWebApp.Models;

namespace PCVMurcorWebApp.Controllers
{
    [Route ("user")]
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        

        [Route ("create")]
        public IActionResult Create(Create create)
        {
            return View();
        }

        [Route ("post")]
        public IActionResult Post(Create c, UserRequirements ur, UserInfo ui)
        {
            return View();
        }

        [Route ("requirements")]
        public IActionResult Requirements(UserRequirements ur)
        {
            return View();
        }

        [Route ("userinformation")]
        public IActionResult UserInformation(UserInfo ui)
        {
            return View();
        }
        
    }
}