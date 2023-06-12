using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7.Models;
namespace WebApplication7.Controllers
{
    public class mainController : Controller
    {
        // GET: main
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Index(modef a )
        {
            a.num1 = a.num1;
            a.num2 = a.num2;
            a.num3 = a.num3;
            a.biggestnum = a.highest();

            return View(a);
        }
    }
}