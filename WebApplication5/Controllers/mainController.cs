using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace WebApplication5.Models
{
    public class calc
    { // properties
        [Required]
        public string name { get; set; }
        [Required]
        [MinLength(8)]
using System.Web;
using System.Web.Mvc;

namespace WebApplication5.Controllers
{
    public class mainController : Controller
    {
        // GET: main
        public ActionResult Index()
        {
            return View();
        }
    }
}