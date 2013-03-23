using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContactWeb.Models.Friend
{
    public class FriendEditViewModel
    {
        public Contact Contact { get; set; }

        public List<SelectListItem> ContactsSelectListItems { get; set; }
    }
}