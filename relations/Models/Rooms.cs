using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace relations.Models
{
    public class Rooms
    {
        public int id { get; set; }
        public string name { get; set; }
        public int CompanyId { get; set; }

        public Company company { get; set; }

    }
}