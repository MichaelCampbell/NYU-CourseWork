using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContactWeb.Models.HTMLFragment;
using ContactWeb.Models;

namespace ContactWeb.Controllers
{
    public class HTMLFragmentController : Controller
    {

        public ActionResult Index(HtmlFragmentListViewModel model)
        {
            model.Contacts = new ContactBUS().GetContacts();
            return View(model);
        }

        public ActionResult Item(HtmlFragmentItemModel model)
        {
            model.Contact = new ContactBUS().GetContact(model.SelectedContactId);
            return View(model);
        }

    }
}
