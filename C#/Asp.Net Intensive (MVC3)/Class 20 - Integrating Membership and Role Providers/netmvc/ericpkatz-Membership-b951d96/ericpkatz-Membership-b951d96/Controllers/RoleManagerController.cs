using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MembershipApp.Models.RolesManager;

namespace MembershipApp.Controllers
{
    public class RoleManagerController : Controller
    {

        public ActionResult Index()
        {
            var model = new RoleManagerViewModel
                            {
                                Roles = Roles.GetAllRoles().ToList()
                            };
            return View(model);
        }
        [HttpPost]
        public ActionResult Insert(RoleManagerViewModel model)
        {
            Roles.CreateRole(model.Roles.Last());
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Change(RoleManagerViewModel model)
        {
            var roleToAdd = model.Roles[model.Index];
            var roleToRemove = Roles.GetAllRoles()[model.Index];
            Roles.CreateRole(roleToAdd);

            var users = Roles.GetUsersInRole(roleToRemove);
            foreach (var username in users)
            {
                Roles.RemoveUserFromRole(username, roleToRemove);
                Roles.AddUserToRole(username, roleToAdd);
            }
            Roles.DeleteRole(roleToRemove);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Delete(RoleManagerViewModel model)
        {
            model.Roles.RemoveAll(r => String.IsNullOrEmpty(r));
            var role = model.Roles[model.Index];
            try
            {
                Roles.DeleteRole(role);
            }
            catch (Exception ex)
            {
                this.ModelState.AddModelError("", ex.Message);
                return View("Index", model);
            }
            return RedirectToAction("Index");
        }
    }
}
