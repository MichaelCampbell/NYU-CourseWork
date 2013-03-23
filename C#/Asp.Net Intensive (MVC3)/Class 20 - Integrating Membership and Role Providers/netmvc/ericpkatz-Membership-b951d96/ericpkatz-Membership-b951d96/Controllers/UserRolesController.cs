using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MembershipApp.Models.UserRoles;

namespace MembershipApp.Controllers
{ 
    //[Authorize(Roles ="Admin")]
    public class UserRolesController : Controller
    {


        public ActionResult EditUserRoles(string username, bool useAjax = false)
        {
            var model = new EditUserRolesViewModel
                            {
                                Username = username,
                                Roles = Roles.GetRolesForUser(username).ToList(),
                                AllRoles = Roles.GetAllRoles().ToList(),
                                UseAjax = useAjax
                            };
            return View(model);
        }

        [HttpPost]   
        public ActionResult EditUserRoles(EditUserRolesViewModel model)
        {
            model.Roles.RemoveAll(r => r == String.Empty);
            var currentRoles = Roles.GetRolesForUser(model.Username);
            foreach(var role in model.Roles)
            {
                if(!currentRoles.Contains(role))
                    Roles.AddUserToRole(model.Username, role);
            }
            foreach(var currentrole in currentRoles)
                if(!model.Roles.Contains(currentrole))
                    Roles.RemoveUserFromRole(model.Username, currentrole);

            TempData["message"] = "Your roles have been saved";
            return RedirectToAction("EditUserRoles", new {username = model.Username, useAjax = model.UseAjax});
        }

        public ActionResult Remove(EditUserRolesViewModel model, int index)
        {
            ModelState.Clear();
            model.Roles.RemoveAt(index);
            model.Roles.RemoveAll(r => r == String.Empty);
            model.AllRoles = Roles.GetAllRoles().ToList();

            return View(model.UseAjax? "Form" : "EditUserRoles", model);
        }

        public ActionResult Add(EditUserRolesViewModel model)
        {
            ModelState.Clear();
            model.AllRoles = Roles.GetAllRoles().ToList();
            model.Roles.RemoveAll(r => r == String.Empty);
            return View(model.UseAjax ? "Form" : "EditUserRoles", model);
        }
    }
}
