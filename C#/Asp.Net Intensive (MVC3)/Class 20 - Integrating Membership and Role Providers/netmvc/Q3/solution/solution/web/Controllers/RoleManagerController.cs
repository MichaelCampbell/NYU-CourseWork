using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MembershipApp.Models.RolesManager;
using System.Web.Security;

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
            model.Roles.RemoveAll(r => String.IsNullOrEmpty(r));
            Roles.CreateRole(model.Roles.Last());
            return View("Form", model);
            //return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult ChangeMode(RoleManagerViewModel model)
        {
            model.Roles.RemoveAll(r => String.IsNullOrEmpty(r));
            return View("Form", model);
        }

        [HttpPost]
        public ActionResult Change(RoleManagerViewModel model)
        {
            model.Roles.RemoveAll(r => String.IsNullOrEmpty(r));
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
            return View("Form", model);
            //return RedirectToAction("Index");
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
                return View("Form", model);
            }
            ModelState.Clear();
            model.Roles.Remove(role);
            return View("Form", model);
            //return RedirectToAction("Index");
        }





    }
}
