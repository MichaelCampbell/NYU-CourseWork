using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.Mvc;

namespace MemberRoleHW.Models.Admin
{
    public class UsersViewModel
    {
        public List<MembershipUser> Users { get; set; }
        public List<SelectListItem> Roles { get; set; }
    }
}