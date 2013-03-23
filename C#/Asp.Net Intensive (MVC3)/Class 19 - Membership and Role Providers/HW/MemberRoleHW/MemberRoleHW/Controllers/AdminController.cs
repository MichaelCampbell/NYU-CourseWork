using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MemberRoleHW.Models;
using MemberRoleHW.Models.Admin;

namespace MemberRoleHW.Controllers
{
    //[Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        #region Users

        public ActionResult Users(string role = "All")
        {
            var roles = Roles.GetAllRoles().ToList();
            roles.Insert(0, "All");
            var model = new UsersViewModel { };
            model.Roles = roles.Select(
                r => new SelectListItem { Text = r, Selected = r == role }
                ).ToList();

            model.Users = Membership.GetAllUsers().OfType<MembershipUser>().Where(u => role == "All" || Roles.IsUserInRole(u.UserName, role)).ToList();

            return View(model);
        }

        public ActionResult RemoveUser(EditUserRolesViewModel model, int index)
        {
            ModelState.Clear();
            model.Roles.Remove(String.Empty);
            model.Roles.RemoveAt(index);
            model.AllRoles = Roles.GetAllRoles().ToList();
            return View("Form", model);
        }

        public ActionResult AddUser()
        {
            return RedirectToAction("Register", "Account");
        }

        public ActionResult LockUser(RegisterModel model, bool islocked)
        {
            return View();
        }

        #endregion Users

        #region Roles

        public ActionResult RolesList()
        {
            var roles = Roles.GetAllRoles().ToList();
            var model = new UsersViewModel { };
            model.Roles = roles.Select(
                r => new SelectListItem { Text = r }
                ).ToList();

            return View(model);
        }
        public ActionResult AddRoles()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddRoles(UsersViewModel newRole)
        {
            var roles = Roles.GetAllRoles().ToList();
            var model = new UsersViewModel {};
            if (newRole != null)
            {
                var role = model.Roles;
                roles.Add(newRole.Roles.ToString());
            }

            //var roles = Roles.GetAllRoles().ToList();
            //var result = new UsersViewModel {};
            //result.Roles = 
            //model.AllRoles = Roles.GetAllRoles().ToList();
            return RedirectToAction("RolesList");
        }

        public ActionResult EditRole()
        {
            return View();
        }

        public ActionResult DeleteRole()
        {
            return View();
        }

        public ActionResult RoleDetails()
        {
            return View();
        }

        public ActionResult EditUserRoles(string username)
        {
            var model = new EditUserRolesViewModel
            {
                Username = username,
                Roles = Roles.GetRolesForUser(username).ToList(),
                AllRoles = Roles.GetAllRoles().ToList()
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult EditUserRoles(EditUserRolesViewModel model)
        {
            var removedFrom = 0;
            var addedTo = 0;
            model.Roles.Remove(String.Empty);

            foreach (var role in Roles.GetRolesForUser(model.Username))
                if (!model.Roles.Contains(role))
                {
                    removedFrom++;
                    Roles.RemoveUserFromRole(model.Username, role);
                }

            foreach (var role in model.Roles)
                if (!Roles.IsUserInRole(model.Username, role))
                {
                    addedTo++;
                    Roles.AddUserToRole(model.Username, role);
                }

            TempData["message"] = String.Format("{0} has been added to {1} roles and removed from {2}", model.Username, addedTo, removedFrom);

            return RedirectToAction("EditUserRoles", new { username = model.Username });
        }

        #endregion Roles

    }
}
