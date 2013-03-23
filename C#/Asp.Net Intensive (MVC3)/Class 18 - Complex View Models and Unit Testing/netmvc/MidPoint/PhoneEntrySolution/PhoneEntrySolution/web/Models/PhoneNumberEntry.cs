using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace web.Models
{
    public class PhoneNumberEntry
    {
        [Required(ErrorMessage = "*")]
        public string PhoneNumber { get; set; }

        public PhoneNumberTypes PhoneNumberType { get; set; }
    }
}