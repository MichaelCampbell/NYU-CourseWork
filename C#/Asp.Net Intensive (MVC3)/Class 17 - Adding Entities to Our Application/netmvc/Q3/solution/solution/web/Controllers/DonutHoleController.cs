using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContactWeb.Models.DonutHole;
using ContactWeb.Models;

namespace ContactWeb.Controllers
{
    public class DonutHoleController : Controller
    {

        public ActionResult Index(DonutHoleViewModel model)
        {
            model.Contacts = new ContactBUS().GetContacts();
            if (model.SelectedContactId == 0)
                model.SelectedContactId = model.Contacts[0].Id;

            return View(model);
        }

    }
}
