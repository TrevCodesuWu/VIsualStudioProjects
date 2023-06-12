using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RolesApplication.Models;
using System.Data.Entity;

namespace RolesApplication.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext(); 
        public HomeController()
        {
            context = new ApplicationDbContext(); 
        }
        public ActionResult Index()
        {
            if (User.IsInRole("DriverRole"))
            {
                return Content("You are one of the drivers :)");
            }
            return View();
        }
        public ActionResult driverdel()
        {
            var order1 = context.orderdb.Where(cc => cc.drivers.DriverEmail == User.Identity.Name).ToList(); 
            if(order1 == null)
            {
                return Content("There is no orders for you to deliver "); 
            }
            
            return View(order1);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}