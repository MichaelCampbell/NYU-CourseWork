using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContactWeb.Models;

namespace ContactWeb.Controllers
{
    public class ContactController : Controller
    {
        ContactBUS _contactBUS;

        public ContactController()
        {
            _contactBUS = new ContactBUS();
        }

        public ActionResult Index(ListViewModel model)
        {
            //model.Contacts = _contactBUS.GetContacts().Where(c => c.Prefix == model.Prefix).ToList();
            var data = _contactBUS.GetContacts().Where(c => c.Prefix == model.Prefix);
            if(model.Ascending)
                model.Contacts = data.OrderBy(c => c.LastName).ToList();
            else
                model.Contacts = data.OrderByDescending(c => c.LastName).ToList();
            model.PrefixCount = _contactBUS.GetContacts().GroupBy(c => c.Prefix).ToDictionary(gr=>gr.Key, gr=>gr.Count());
            return View(model);
        }

        public ActionResult Details(int id)
        {
            var model = _contactBUS.GetContact(id);
            return View(model);
        }

        public ActionResult Delete(Contact contact)
        {
            var deletedItem = _contactBUS.GetContact(contact.Id);
            _contactBUS.Delete(contact);
            return RedirectToAction("Index", new { Prefix = deletedItem.Prefix });
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new Contact { });
        }

        [HttpPost]
        public ActionResult Create(Contact c)
        {
            _contactBUS.Create(c);
            return RedirectToAction("Index", new { Prefix = c.Prefix, Ascending = true });
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var _contact = _contactBUS.GetContact(id);
            return View(_contact);
        }

        [HttpPost]
        public ActionResult Edit(Contact c)
        {
            _contactBUS.Edit(c);
            return RedirectToAction("Index", new { Prefix = c.Prefix, Ascending = true });
        }










    }
}
