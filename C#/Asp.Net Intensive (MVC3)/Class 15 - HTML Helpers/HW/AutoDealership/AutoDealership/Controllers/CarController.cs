using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoDealership.Models;

namespace AutoDealership.Controllers
{
    public class CarController : Controller
    {
        CarBUS _carBUS;

        public CarController()
        {
            _carBUS = new CarBUS();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List(string vin, string color)
        {
            var model = _carBUS.GetCars().OrderBy(c=> c.Price).Where(c=> c.Color == color);

            if (string.IsNullOrEmpty(color))
            {
                model = _carBUS.GetCars().OrderBy(c => c.Price);
            }

            return View(model);
        }

        public ActionResult Details(string vin)
        {
            var model = _carBUS.GetCar(vin);

            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new Car { });
        }

        [HttpPost]
        public ActionResult Create(Car car)
        {
            if (_carBUS.GetCar(car.Vehicle_Identification_Number) != null)
            {
                ModelState.AddModelError(String.Empty, "VIN already exists");
            }

            if (!ModelState.IsValid)
                return View(car);
            _carBUS.Create(car);

            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Edit(string vin)
        {
            var _contact = _carBUS.GetCar(vin);
            return View(_contact);
        }

        [HttpPost]
        public ActionResult Edit(Car car)
        {
            if (_carBUS.GetCar(car.Vehicle_Identification_Number) != null)
                ModelState.AddModelError(String.Empty, "VIN already in use");
            if (!ModelState.IsValid)
                return View(car);
            _carBUS.Edit(car);
            return RedirectToAction("List");
        }

        [HttpPost]
        public ActionResult Delete(Car car)
        {
            _carBUS.Delete(car);
            return RedirectToAction("List");
        }
    }
}
