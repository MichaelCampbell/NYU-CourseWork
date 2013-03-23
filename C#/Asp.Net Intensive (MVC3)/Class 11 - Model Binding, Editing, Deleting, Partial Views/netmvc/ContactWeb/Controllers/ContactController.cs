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

        public ActionResult List(string prefix)
        {
            var _db = new ContactBUS().GetContacts();
            var contacts = _db.Where(c => prefix == null || c.FirstName.ToLower().StartsWith(prefix.ToLower())).ToList();
            var letters = _db.Select(c => c.FirstName.Substring(0, 1).ToUpper()).Distinct().OrderBy(letter => letter).ToList();
            var model = new ContactViewModel
            {
                SelectedLetters = letters,
                Contacts = contacts,
                SelectedLetter = prefix != null ? prefix.ToUpper() : String.Empty
            };
            
            //var model = new List<Contact>();
            //foreach(var contact in _db)
            //    if(prefix == null || contact.FirstName.ToLower().StartsWith(prefix.ToLower()))
            //        model.Add(contact);

            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = new ContactBUS().GetContact(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(Contact contact)
        {
            var _db = new ContactBUS().GetContacts();
            if(!ModelState.IsValid)
                return View(contact);
            foreach (var c in _db)
            {
                if (c.Id == contact.Id)
                {
                    c.LastName = contact.LastName;
                    c.FirstName = contact.FirstName;
                    c.Email = contact.Email;
                    break;
                }
            }
            return RedirectToAction("Detail", new { contact.Id });
        }

        [HttpGet]
        public ActionResult Insert()
        {
            var contact = new Contact();
            return View(contact);
        }

        [HttpPost]
        public ActionResult Insert(Contact contact)
        {
            
            if (!ModelState.IsValid)
            {
                return View(contact);
            }

            var _db = new ContactBUS().GetContacts();

            contact.Id = _db.Max(c => c.Id) + 1;
            _db.Add(contact);

            return RedirectToAction("Detail", new { id = contact.Id });
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var _db = new ContactBUS().GetContacts();
            var contact = new ContactBUS().GetContact(id);

            _db.Remove(contact);
            return RedirectToAction("List");
        }
        public int MyProperty { get; set; }

        public ActionResult NotFound()
        {
            return View();
        }

        public ActionResult Detail(int id)
        {
            var contact = new ContactBUS().GetContact(id);
            if (contact == null)
                return RedirectToAction("NotFound");

            return View(contact);
        }













    }
}





