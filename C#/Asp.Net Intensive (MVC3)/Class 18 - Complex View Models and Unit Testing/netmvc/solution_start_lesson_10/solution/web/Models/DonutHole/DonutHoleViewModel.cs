using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactWeb.Models.DonutHole
{
    public class DonutHoleViewModel
    {
        public int SelectedContactId { get; set; }
        public List<Contact> Contacts { get; set; }

        public bool IsSelected(Contact contact)
        {
            return contact.Id == SelectedContactId;
        }

        public string CssClass(Contact contact)
        {
            return IsSelected(contact) ? "class=selected" : String.Empty;
        }
    }
}