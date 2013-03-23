using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContactWeb.Models;

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

        public ActionResult LuckyNumberView(int luckyNumber)
        {
            var users = new ContactBUS().GetLuckyNumber(luckyNumber);
            return View(users);
        }
    }
}
