using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContactWeb.Models
{
    public class ContactViewModel : Controller
    {

        public List<string> SelectedLetters { get; set; }
        public List<Contact> Contacts { get; set; }
        public string SelectedLetter { get; set; }

    }
}
