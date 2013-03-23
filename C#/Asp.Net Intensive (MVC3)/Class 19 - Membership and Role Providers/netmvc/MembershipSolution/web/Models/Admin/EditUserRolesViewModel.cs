using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web.Models.Admin
{
    public class EditUserRolesViewModel
    {
        private List<string> _roles;
        public List<string> Roles
        {
            get
            {
                if (_roles == null)
                {
                    _roles = new List<string>();
                }
                return _roles;
            }
            set { _roles = value; }
        }
        public List<string> AllRoles { get; set; }
        public List<SelectListItem> AvailableRoles()
        {
            return AllRoles.Where(r => !Roles.Contains(r)).Select(r => new SelectListItem { Text = r }).ToList();
        }

        public string Username { get; set; }

    }
}