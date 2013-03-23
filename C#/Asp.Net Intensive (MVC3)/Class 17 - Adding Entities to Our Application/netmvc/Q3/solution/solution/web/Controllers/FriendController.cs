using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BUS;
using ContactWeb.Models;

namespace ContactWeb.Controllers
{
    public class FriendController : Controller
    {

        public ActionResult Edit(int id)
        {
            var contactLogic = new ContactBUS();
            var contact = contactLogic.GetContact(id);
            return View(contact);
        }
        [HttpPost]
        public ActionResult Edit(Contact contact)
        {
            var friendLogic = new FriendBUS();
            var friends =
                contact.Friends.Select(c => new Friend() {ContactId1 = c.Id, ContactId2 = contact.Id}).ToList();
            friendLogic.Save(contact, friends);
            return RedirectToAction("Edit", new {id = contact.Id});
        }
    }
}
