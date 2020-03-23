using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Level2.Controllers
{
    public class AboutUsController : Controller
    {
        //implement the code here
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult About()
        {
            return View();
        }



    }
}