using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContactWeb.Models;

namespace ContactWeb.Controllers
{
    public class JsonController : Controller
    {
        public ActionResult Index()
        {
            return View(new ContactBUS().GetContacts());
        }

        public ActionResult Item(int id)
        {
            return new JsonResult
            {
                Data = new ContactBUS().GetContact(id),
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }

    }
}
