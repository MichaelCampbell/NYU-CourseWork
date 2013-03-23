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
            var logic = new ContactBUS();

            var groupings = logic.Contacts.Select(
                c => c.LuckyNumber.HasValue ? c.LuckyNumber.Value : 0).GroupBy(item => item);

            model.LuckyNumberMap = groupings.ToDictionary(gr => gr.Key, gr => gr.Count());

            var results =

            model.Contacts = new ContactBUS().Contacts.Where(c => c.LuckyNumber == model.SelectedLuckyNumber).ToList();

            //model.LuckyNumberMap = new ContactBUS().GetContacts().Where(c=>c.LuckyNumber.HasValue).GroupBy(c => c.LuckyNumber).ToDictionary(gr => gr.Key.Value, gr => gr.Count());

            //if (new ContactBUS().GetContacts().Where(c => !c.LuckyNumber.HasValue).Any())
            //    model.LuckyNumberMap.Add(0, new ContactBUS().GetContacts().Where(c => !c.LuckyNumber.HasValue).Count());

            return View(model);
        }

    }
}
