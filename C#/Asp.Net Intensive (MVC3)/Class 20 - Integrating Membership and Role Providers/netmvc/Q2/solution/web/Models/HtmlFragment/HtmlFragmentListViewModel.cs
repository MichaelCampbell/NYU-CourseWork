using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactWeb.Models.HtmlFragment
{
    public class HtmlFragmentListViewModel
    {
        public int SelectedContactId { get; set; }

        public List<Contact> Contacts { get; set; }
    }
}