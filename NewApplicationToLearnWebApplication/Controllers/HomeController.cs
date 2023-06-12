using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewApplicationToLearnWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult nextPage()
        {
            ViewBag.personName = "Trevlin";
            ViewBag.personAge = 21;
            ViewBag.personGender = "Male"; 
            return View(); 
        }
        



    }
}