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

        

        [HttpGet, Route ("create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost, Route("create")]
        public IActionResult Create(UserInfo ui)
        {
            if (!ModelState.IsValid)
                return View();

            ui.TodayDate = DateTime.Now;
            

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

        [Route ("reviewerinfo")]
        public IActionResult ReviewerInfo()
        {
            return View();
        }
        [Route("applicationaccess")]
        public IActionResult ApplicationAccess()
        {
            return View();
        }

        [Route ("userinformation")]
        public IActionResult UserInformation(UserInfo ui)
        {
            return View();
        }

        [Route("viewform")]
        public IActionResult ViewForm()
        {
            return View();
        }

        [Route("comments")]
        public IActionResult Comments()
        {
            return View();
        }

    }
}