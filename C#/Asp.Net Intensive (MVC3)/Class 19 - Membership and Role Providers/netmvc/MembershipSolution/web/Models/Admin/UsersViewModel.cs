using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace web.Models.Admin
{
    public class UsersViewModel
    {
        public List<MembershipUser> Users { get; set; }
        public List<SelectListItem> Roles { get; set; }

    }
}