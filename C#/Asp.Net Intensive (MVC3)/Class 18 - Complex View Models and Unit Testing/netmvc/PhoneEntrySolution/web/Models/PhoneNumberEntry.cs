using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace web.Models
{
    public class PhoneNumberEntry
    {
        [Required]
        public string PhoneNumber { get; set; }

        public PhoneNumberTypes PhoneNumberType { get; set; }
    }
}