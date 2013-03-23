using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactWeb.Models
{
    public class ContactViewModel
    {
        public List<Contact> Contacts { get; set; }
        public List<string> SelectedLetters { get; set; }
        public string SelectedLetter { get; set; }
        public int lastId { get; set; }
    }
}