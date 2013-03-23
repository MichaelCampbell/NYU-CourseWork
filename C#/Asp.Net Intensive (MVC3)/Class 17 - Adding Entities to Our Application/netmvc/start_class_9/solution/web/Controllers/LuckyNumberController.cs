using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContactWeb.Models;
using ContactWeb.Models.LuckyNumber;

namespace ContactWeb.Controllers
{
    public class LuckyNumberController : Controller
    {

        public ActionResult Index()
        {
            var user = new ContactBUS().GetHighestLuckyNumber();
            return View(user);
        }

        public ActionResult List(int low, int high)
        {
            var users = new ContactBUS().GetUsersByLuckyNumberRange(low, high);
            return View(users);
        }

        public ActionResult Filter(FilterViewModel model)
        {
            model.Contacts = new ContactBUS().GetContacts().Where(c => c.LuckyNumber == model.SelectedLuckyNumber || (model.SelectedLuckyNumber == 0 && ! c.LuckyNumber.HasValue)).ToList();
            model.LuckyNumberMap = new ContactBUS().GetContacts().Where(c=>c.LuckyNumber.HasValue).GroupBy(c => c.LuckyNumber).ToDictionary(gr => gr.Key.Value, gr => gr.Count());
            
            if(new ContactBUS().Where(c=>!c.LuckyNumber.HasValue).Any())
            {
                model.LuckyNumberMap.Add(0, model.Contacts.Where(c => !c.LuckyNumber.HasValue).Count());
            }
            
            return View(model);
        }

    }
}
