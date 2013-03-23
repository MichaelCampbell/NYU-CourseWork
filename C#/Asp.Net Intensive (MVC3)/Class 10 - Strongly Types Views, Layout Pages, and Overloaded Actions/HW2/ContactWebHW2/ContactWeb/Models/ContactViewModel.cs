using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactWeb.Models
{
    public class ContactViewModel
    {
        public List<string> SelectedLetters { get; set; }

        public List<Contact> Contacts { get; set; }
    }
}