using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MembershipApp.Models
{
    public class UserManagerModel
    {
        public IEnumerable<MembershipUser> Users { get; set; }

        public List<SelectListItem> Roles { set; get; }
    }
}