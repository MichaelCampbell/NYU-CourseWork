using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AutoDealership.Models
{
    public class Car
    {
        [Required]
        public int Year { get; set; }
        
        public string Make { get; set; }

        public string Model { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        public int Price { get; set; }
        
        [Required]
        public string Vehicle_Identification_Number { get; set; }
        
    }
}