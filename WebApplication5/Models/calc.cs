using System;
using System.Collections.Generic;
        public string sname { get; set; }
        public int YOB { get; set; }
        public int age { get; set; }

        // method 

        public int calcAge()
        {

            return DateTime.Now.Year - YOB;

        }



    }
}