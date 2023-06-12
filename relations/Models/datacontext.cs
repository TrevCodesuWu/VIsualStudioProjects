using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace relations.Models
{
    public class datacontext : DbContext
    {

        public datacontext()
            : base("datacontext")
        {

        }
        public DbSet<Company> CopmanyDb { get; set; }
        public DbSet<Employee> EmployeeDb { get; set; }
        public DbSet<Rooms> RoomsDb { get; set; }

        
    }
}