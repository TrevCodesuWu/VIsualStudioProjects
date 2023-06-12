using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Simple_Project_with_fluent_Api.Models
{
    public class contextClass : DbContext
    {
        public contextClass() : base("newContextDb")
        {

        }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }

    }
}