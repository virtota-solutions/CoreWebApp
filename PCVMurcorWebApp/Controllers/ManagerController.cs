﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PCVMurcorWebApp.Controllers
{
    public class ManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [Route("blog/{year:int}/{month:int}/{key}")]
        public IActionResult Post(int year, int month, string key)
        {
            return View();
        }
    }
}