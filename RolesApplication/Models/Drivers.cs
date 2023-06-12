using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RolesApplication.Models
{
    public class Drivers
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string DriverEmail { get; set; }
        public string cellnum { get; set; }

    }
}