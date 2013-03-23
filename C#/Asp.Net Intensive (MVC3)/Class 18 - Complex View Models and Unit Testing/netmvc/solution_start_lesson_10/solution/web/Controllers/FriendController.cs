using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContactWeb.Models;
using BUS;
using ContactWeb.Models.Friend;

namespace ContactWeb.Controllers
{
    public class FriendController : Controller
    {

        public ActionResult Edit(int id)
        {
            var contactLogic = new ContactBUS();
            var model = new FriendEditViewModel
                            {
                                Contact = contactLogic.GetContact(id)
                            };
            var friendIds = model.Contact.Friends.Select(f => f.Id).ToList();
            friendIds.Add(id);//can't add friend to himself.
            model.ContactsSelectListItems =
                contactLogic.Contacts.Where(c => !friendIds.Contains(c.Id)).Select(
                    c => new SelectListItem {Text = c.FullName, Value = c.Id.ToString()}).ToList().OrderBy(item => item.Text).ToList();


            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(FriendEditViewModel model)
        {
            var friendLogic = new FriendBUS();
            var friends = model.Contact.Friends.Select(c => new Friend
            {
                ContactId1 = c.Id,
                ContactId2 = model.Contact.Id
            }).ToList();

            friendLogic.Save(model.Contact, friends);

            return RedirectToAction("Edit", new { id = model.Contact.Id });
        }

    }
}
