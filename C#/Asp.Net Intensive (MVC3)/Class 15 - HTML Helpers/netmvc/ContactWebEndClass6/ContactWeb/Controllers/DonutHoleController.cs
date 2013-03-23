using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContactWeb.Models;
using ContactWeb.Models.DonutHole;

namespace ContactWeb.Controllers
{
    public class DonutHoleController : Controller
    {

        public ActionResult Index(DonutHoleViewModel model)
        {
            //System.Threading.Thread.Sleep(2000);
            
            model.Contacts = new ContactBUS().GetContacts();
            if(model.SelectedContactId == 0)
            {
                model.SelectedContactId = model.Contacts[0].Id;
            }
            return View(model);
        }

    }
}
