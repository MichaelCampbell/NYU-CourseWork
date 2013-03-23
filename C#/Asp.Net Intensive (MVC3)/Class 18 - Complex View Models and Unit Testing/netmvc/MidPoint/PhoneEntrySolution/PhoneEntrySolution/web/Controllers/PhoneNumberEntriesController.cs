using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web.Models;

namespace web.Controllers
{
    public class PhoneNumberEntriesController : Controller
    {
        //
        // GET: /PhoneNumberEntries/

        public ActionResult Index()
        {
            var model = new PhoneNumberEntriesViewModel {};
            model.Entries.Add(new PhoneNumberEntry{PhoneNumberType = PhoneNumberTypes.Cell});
            return View(model);
        }

        public ActionResult Add(PhoneNumberEntriesViewModel model)
        {
            model.Entries.Add(new PhoneNumberEntry{PhoneNumberType = model.AvailableTypes().First()});

            return View("Form", model);
        }

        public ActionResult Change(PhoneNumberEntriesViewModel model)
        {
            return View("Form", model);
        }

        public ActionResult Remove(PhoneNumberEntriesViewModel model, int index)
        {
            //look into the following
            ModelState.Clear();
            model.Entries.RemoveAt(index);
            return View("Form", model);
        }

        [HttpPost]
        public ActionResult Index(PhoneNumberEntriesViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return View("Form", model);    
            }
            TempData["model"] = model;
            return RedirectToAction("Saved");
            
        }

        public ActionResult Saved()
        {
            var model = new PhoneNumberEntriesViewModel {};
            if(TempData["model"] != null)
            {
                model = TempData["model"] as PhoneNumberEntriesViewModel;
            }
            return View(model);
        }
    }
}
