using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebApplication3.Models
{
    public class wages
    {
        [Required]
        public string name { get; set; }
        [Required(ErrorMessage = "Enter a value b")]
        public double hoursworked { get; set; }
        [Required]
        public double rateofpay { get; set; }
        public double Wages { get; set; }
        public double subtract { get; set; }

        public double num1 { get; set; }
        public double num2 { get; set; }


        public double Calc()
        {
            return hoursworked * rateofpay;
        }
        public double Sub()
        {
           
            return num1 - num2;
        }
    }
}