using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cab_booking1.Controllers
{
    public class TimingsController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to Timings!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
