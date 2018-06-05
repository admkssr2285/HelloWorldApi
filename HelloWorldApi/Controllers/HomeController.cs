using System;
using System.Collections.Generic;
using HelloWorldApi.Application;
using HelloWorldApi.Models;
using System.Web.Mvc;

namespace HelloWorldApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Hellow World Api";

            return View();
        }
        public ActionResult GetAllGreetings()
        {
            GreetingHelp helper = new GreetingHelp();

            return View("AllGreetingList",helper.GetSupportedGreetings());
        }
    }
}
