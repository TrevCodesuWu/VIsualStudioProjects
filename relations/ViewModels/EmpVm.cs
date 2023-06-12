using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using relations.Models; 

namespace relations.ViewModels
{
    public class EmpVm
    {
        public Company Company { get; set; }
        public List<Employee> employeeVmlist { get; set; }

    }
}