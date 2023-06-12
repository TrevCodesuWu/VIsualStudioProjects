using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class mainController : Controller
    {
        // GET: main
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(wages ob)
        {
            ob.name = ob.name;
            ob.hoursworked = ob.hoursworked;
            ob.rateofpay = ob.rateofpay;
            ob.Wages = ob.Calc();

            return View(ob);
        }
        public ActionResult About()
        {
            return View();
        }
        [HttpPost]
        public ActionResult About(wages n)
        {
            n.num1 = n.num1;
            n.num2 = n.num2;
            n.subtract = n.Sub();

            return View(n);
        }
    }
}