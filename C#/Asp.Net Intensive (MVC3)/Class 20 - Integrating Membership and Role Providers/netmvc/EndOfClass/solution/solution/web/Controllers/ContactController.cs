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
            model.Page = page;

            var result = _logic.Contacts.Skip(page * 50).Take(50);
            model.Contacts = result.ToList();

            model.TotalPages = _logic.Contacts.Count() / 50;

            return View(model);
        }


        public ActionResult Create(string email, int page)
        {
            Membership.CreateUser(email, "password", email);
            return RedirectToAction("Index", new { page = page});
        }

        public ActionResult Remove(string email, int page)
        {
            Membership.DeleteUser(email);
            return RedirectToAction("Index", new { page = page});
        }


    }
}
