﻿using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index() 
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes=1)
        {
            ViewData["Message"] = "Hello "+ name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }

    }

    //Get: /HelloWorld/
    //public string Index()
    //{
    //    return "This is my default action...";
    //}

    //Get: /HelloWorld/Welcome
    //Required Using System.Text.Encodings.Web
    //Get: /HelloWorld/Welcome?name=manuel&numtimes=5/
    //public string Welcome(string name, int numTimes = 1)
    //{
    //    // return "This is the melcome action method...";
    //    return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
    //}
//}
}
