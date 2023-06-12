using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Simple_Project_with_fluent_Api.Models
{
    public class Employee
    {
        public int Id { get; set; } 
        public string Employee_name { get; set; }
        public string Employee_age { get; set; }
        public double Employee_salary { get; set; }
        public double Employee_salary_added_vat { get; set; }

        public DateTime Employee_start_date { get; set; }

    }
}