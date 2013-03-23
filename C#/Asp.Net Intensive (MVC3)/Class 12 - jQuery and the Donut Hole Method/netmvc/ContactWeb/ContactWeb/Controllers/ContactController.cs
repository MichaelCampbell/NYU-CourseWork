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
            model.Contacts = _contactBUS.GetContacts().Where(c => c.Prefix == model.Prefix).ToList();
            model.PrefixCount = _contactBUS.GetContacts().GroupBy(c => c.Prefix).ToDictionary(gr => gr.Key, gr => gr.Count());
            return View(model);
        }

    }
}
