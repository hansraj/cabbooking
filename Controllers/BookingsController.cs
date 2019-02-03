using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using cab_booking1.Models;

namespace cab_booking1.Controllers
{
    public class BookingsController : Controller
    {
        CBEntities ent = new CBEntities();
        public string message = "";
        public BOOKING new_booking = new BOOKING();
        public ActionResult Index()
        {
            ViewBag.Message = message;
            if (new_booking != null)
                ViewBag.Message = new_booking.ID + new_booking.CAB_ID + new_booking.EMP_ID + new_booking.LOC_ID;
            //ent.TIMINGS.ToList();
            
            ViewData["Locations"] = ent.Locations.ToList();
            return View(ent.TIMINGS.ToList());
            
        }

        public ActionResult About()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Book(String timing, String loc)
        {

            new_booking.EMP_ID = 4473;
            new_booking.TIMING = DateTime.Now;
            new_booking.LOC_ID = 1;
            new_booking.ID = 1;
            //ent.AddToBOOKINGs(new_booking);
            ent.BOOKINGs.AddObject(new_booking);
            //ent.SaveChanges();
            BOOKING.CreateBOOKING(1);
            message = "New booking created";
            return RedirectToAction("Index");
            
        }
    }
}
