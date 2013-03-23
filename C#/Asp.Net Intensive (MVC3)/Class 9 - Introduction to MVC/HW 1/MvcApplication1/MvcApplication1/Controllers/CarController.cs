using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class CarController : Controller
    {
        
        private List<Car> _cars
        {
            get
            {
                return new List<Car> {
                    new Car{Make = "Acura", Model = "TL", Year = Convert.ToInt32(DateTime.Now.Year), Price = 41825},
                    new Car{Make = "BMW", Model = "M3", Year = Convert.ToInt32(DateTime.Now.Year), Price = 63250},
                    new Car{Make = "Chevrolet", Model = "Camaro", Year = Convert.ToInt32(2011), Price = 30000}


                };
            }
        }

        public ActionResult Index()
        {
            return View(_cars);
        }

        public ActionResult Detail(string make)
        {
            return View(_cars.Where(p=>p.Make == make).Single());
        }

    }
}
