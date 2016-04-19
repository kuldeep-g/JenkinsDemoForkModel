using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplicationJenkinsDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ///Changes made by developer 1.
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            ///Another change made by developer 1.
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
