using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactWeb.Models.HTMLFragment
{
    public class HtmlFragmentItemModel
    {
        public int SelectedContactId { get; set; }
        public Contact Contact { get; set; }

        public bool IsSelected(Contact contact)
        {
            return contact.Id == SelectedContactId;
        }

        public string CSSString(Contact contact)
        {
            return IsSelected(contact) ? "class=selected" : String.Empty;
        }
    }
}