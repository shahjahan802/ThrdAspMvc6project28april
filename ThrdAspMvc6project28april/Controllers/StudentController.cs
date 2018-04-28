using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ThrdAspMvc6project28april.Models;

namespace ThrdAspMvc6project28april.Controllers
{
    public class StudentController : Controller
    {    [HttpGet]  
        public IActionResult StudentView()
        {
            return View();
        } 
        [HttpPost]
        public IActionResult StudentView( Student obj)
        {
            return View();
        }
        [HttpGet]
        public IActionResult StudentOld()
        {
            return View();
        }
        [HttpPost]
        public IActionResult StudentOld(string Name ,string Course)
        {
            return View();
        }
    }
}