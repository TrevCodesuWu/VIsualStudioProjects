using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Simple_Project_with_fluent_Api.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Customer_name { get; set; }
        public int Customer_age { get; set; }
        public bool Customer_savings_card { get; set; }
    }
}