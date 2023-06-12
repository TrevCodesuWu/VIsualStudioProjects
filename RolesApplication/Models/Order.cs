using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RolesApplication.Models
{
    public class Order
    {
        public int id { get; set; }
       
        public string userEmail { get; set; }
        [Required]
        public string trackingnum { get; set; }
        public string deliverystatus { get; set; } = Convert.ToString(status.Pending);
        public Drivers drivers { get; set; }

        public int? DriversId { get; set; }

    }
}