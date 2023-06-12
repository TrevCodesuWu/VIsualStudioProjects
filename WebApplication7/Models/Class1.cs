using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication7.Models
{
    public class Class1
    {
        public double num1 { get; set; }
        public double num2 { get; set; }
        public double num3 { get; set; }
        public double answer { get; set; }
        public double biggestnum { get; set; }


        public double CalcSum()
        {
            return num1 + num2 + num3;
        }

        public double highest()
        {
            if (num1 > num2) && (num1 > num3)
               {
                biggestnum = num1;
            }
  else if (num2 > num1) && (num2 > num3)
               {
                biggestnum = num2;
            }
  else if
       {
                biggestnum = num3;
            }

            return biggestnum;
        }


    }
}