using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using web.Models.Admin;

namespace web.Controllers
{
    [Authorize(Roles="Admin")]
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        public ActionResult Users(string role = "All")
        {
            var roles = Roles.GetAllRoles().ToList();
            roles.Insert(0, "All");
            var model = new UsersViewModel {};
            model.Roles = roles.Select(
                r => new SelectListItem {Text = r, Selected = r == role}).ToList();

            model.Users = Membership.GetAllUsers().OfType<MembershipUser>().Where(u=> role =="All" || Roles.IsUserInRole(u.UserName, role)).ToList();

            return View(model);
        }
        public ActionResult EditUserRoles(string username)
        {

            var model = new EditUserRolesViewModel { Username = username, Roles = Roles.GetRolesForUser(username).ToList(), AllRoles = Roles.GetAllRoles().ToList()};
            //var results = from role in Roles.GetAllRoles()
            //              where !model.Roles.Contains(role)
            //              select role;
            //model.AvailableRoles = (from role in results
            //                        select new SelectListItem {Text = role}).ToList();
            ////model.AvailableRoles = Roles.GetAllRoles().Where(r => !model.Roles.Contains(r)).Select(r=> new SelectListItem{Text = r}).ToList();

            return View(model);
        }

        public ActionResult Remove(EditUserRolesViewModel model, int index)
        {
            ModelState.Clear();
            model.Roles.Remove(String.Empty);
            model.Roles.RemoveAt(index);
            model.AllRoles = Roles.GetAllRoles().ToList();

            return View("Form", model);
        }

        public ActionResult Add(EditUserRolesViewModel model)
        {

            model.AllRoles = Roles.GetAllRoles().ToList();
            return View("Form", model);
        }
        [HttpPost]
        public ActionResult EditUserRoles(EditUserRolesViewModel model)
        {
            var removedFrom = 0;
            var addedTo = 0;
            model.Roles.Remove(String.Empty);
            foreach (var role in Roles.GetRolesForUser(model.Username))
            {
                if(!model.Roles.Contains(role))
                {
                    removedFrom++;
                    Roles.RemoveUserFromRole(model.Username, role);
                }
            }

            foreach(var role in model.Roles)
            {
                if(!Roles.IsUserInRole(model.Username, role))
                {
                    addedTo++;
                    Roles.AddUserToRole(model.Username, role);
                }
            }
            TempData["message"] = String.Format("{0} has been added to {1} roles and removed from", model.Username, addedTo, removedFrom);
            return RedirectToAction("EditUserRoles", new {username = model.Username});
        }
    }
}
