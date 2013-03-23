using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MembershipApp.Models.Contact;

namespace MembershipApp.Controllers
{
    public class ContactController : Controller
    {
        BUS.ContactBUS _logic = new BUS.ContactBUS();

        public ActionResult Index(int page = 0)
        {
            var model = new ContactListViewModel();
            var result = _logic.Contacts.Skip(50 * page).Take(50);
            model

            return View(model);
        }

        public ActionResult Create(string email)
        {
            Membership.CreateUser(email, "password", email);

            return RedirectToAction("Index");
        }

        public ActionResult Remove(string email)
        {
            Membership.DeleteUser(email);

            return RedirectToAction("Index");
        }

    }
}
