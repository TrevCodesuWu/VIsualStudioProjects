using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class mainController : Controller
    {
        // GET: main
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Class1 sum)
        {
            sum.number1 = sum.number1;
            sum.number2 = sum.number2;
            sum.number3 = sum.number3;
            sum.answer = sum.CalcSum();



            return View(sum);
        }
    }
}