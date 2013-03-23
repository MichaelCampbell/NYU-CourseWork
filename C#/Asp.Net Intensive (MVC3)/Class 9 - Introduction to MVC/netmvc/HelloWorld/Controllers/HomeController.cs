using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {

        }
        
        //public string Index()
        //{
        //    return "<span id=test style=\"color:orange\">Hello World</span>";
        //}

        public ActionResult Index()
        {
            return View();
        }

        public string Detail(int id)
        {
            return String.Format("Detail for {0}", id);
        }


    }
}
