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

            var groupings =  logic.Contacts.Select(c => c.LuckyNumber.HasValue ? c.LuckyNumber.Value : 0 ).GroupBy(item => item);

            model.LuckyNumberMap = groupings.ToDictionary(gr => gr.Key, gr => gr.Count());

            var results = new ContactBUS().Contacts.Where(c => c.LuckyNumber == model.SelectedLuckyNumber || (model.SelectedLuckyNumber == 0 && !c.LuckyNumber.HasValue));
            
            model.Contacts = results.ToList();


            return View(model);
        }

    }
}
