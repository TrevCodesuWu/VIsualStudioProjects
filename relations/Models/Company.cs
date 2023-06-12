using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using relations.Models;
using System.Data.Entity; 

namespace relations.Models
{
    public class Company
    {
        [Key]
        public int id { get; set; }
        [Required]
        [Display(Name="Company Name")]
        public string Name { get; set; }
        public int EmployeeId { get; set; }

        public List<Rooms> Rooms { get; set; }
        public List<Employee> Employee { get; set; }
        // Navigation Property 
      

       

        /*
 
        
          public List<Rooms> listRooms { get; set; }
          public int RoomsId { get; set; } // THis should be a array to support all the values that is going to come from the mutliselector list that is shown to the user . 


         */
    }
}