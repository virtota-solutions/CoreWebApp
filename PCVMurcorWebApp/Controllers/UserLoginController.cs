﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PCVMurcorWebApp.Controllers
{
    public class UserLoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult UserLogin()
        {
            return View();
        }
  
       
    }
}