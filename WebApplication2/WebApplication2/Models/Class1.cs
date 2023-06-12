using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Class1
    {
        public double number1 { get; set;  }
        public double number2 { get; set; }
        public double number3 { get; set; }
        public double answer { get; set; }

        public double CalcSum()
        {

            return number1 + number2 + number3;
        }
    }
}