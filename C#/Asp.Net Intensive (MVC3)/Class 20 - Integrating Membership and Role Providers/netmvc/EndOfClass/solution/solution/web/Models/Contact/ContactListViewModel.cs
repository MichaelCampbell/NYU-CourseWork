using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace MembershipApp.Models.Contact
{
    public class ContactListViewModel
    {
        public List<BUS.Contact> Contacts { get; set; }

        public int Page { get; set; }

        public int TotalPages { get; set; }

        public bool FirstPage
        {
            get
            {
                return Page == 0;
            }
        }

        public bool LastPage
        {
            get
            {
                return Page == TotalPages - 1;
            }
        }
    }
}