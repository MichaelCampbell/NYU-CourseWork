using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MembershipApp.Models.UserRoles
{
    public class EditUserRolesViewModel
    {
        public string Username { get; set; }
        public List<string> Roles { get; set; }
        public List<string> AllRoles { get; set; }
        public List<SelectListItem> AvailableRoles()
        {
            return this.AllRoles.Where(r => !Roles.Contains(r)).Select(r => new SelectListItem() {Text = r}).ToList();   
        }

        public bool UseAjax { get; set; }

        public bool MoreRoles()
        {
          return AvailableRoles().Count() > 0; 
        }
    }
}