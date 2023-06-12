using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace proj2.Models
{
    public class model
    {
      
        public int num1 { get; set; }
        public int num2 { get; set; }
        public int ans { get; set; }

        public int Calc()
        {

            return num1 + num2;
        }

    }
}