using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using System.IO;
using System.Text;

namespace AutoDealership.Models
{
    public class CarDAL
    {
        public CarDAL()
        {

        }

        private Car FromXElement(XElement node)
        {
            return new Car
            {
                Year = (int)node.Element("Year"),
                Price = (int)node.Element("Price"),
                Color = node.Element("Color").Value,
                Vehicle_Identification_Number = node.Element("Vehicle_Identification_Number").Value,
                Make = node.Element("Make").Value,
                Model = node.Element("Model").Value
            };
        }
        private XElement ToXElement(Car car)
        {
            var node = new XElement("Car",
                        new XElement("Year", car.Year),
                        new XElement("Price", car.Price),
                        new XElement("Color", car.Color),
                        new XElement("Vehicle_Identification_Number", car.Vehicle_Identification_Number),
                        new XElement("Make", car.Make),
                        new XElement("Model", car.Model)
                        );
            return node;
        }

        private string GetPath()
        {
            return System.Web.HttpContext.Current.Server.MapPath("~/App_Data/Cars.xml");
        }

        private XDocument GetDocument()
        {
            return XDocument.Load(GetPath());
        }

        public List<Car> GetCars()
        {
            var doc = GetDocument();

            var results = from car in doc.Descendants("Car")
                          select FromXElement(car);

            return results.ToList();
        }

        public Car GetCar(string vin)
        {
            var doc = GetDocument();
            var results = doc.Descendants("Car").Where(car => car.Element("Vehicle_Identification_Number").Value.ToLower() == vin.ToLower()).Select(car => FromXElement(car));
            return results.SingleOrDefault();
        }

        //public Car GetCar(string color)
        //{
        //    var doc = GetDocument();
        //    var results = doc.Descendants("Car").Where(car => car.Element("Color").Value.ToLower() == color.ToLower()).Select(car => FromXElement(car));
        //    return results.SingleOrDefault();
        //}

        public string Create(Car car)
        {
            var vin = GetCars().Count > 0 ? this.GetCars().Max(c => c.Vehicle_Identification_Number) + DateTime.Today.TimeOfDay.Seconds : Convert.ToString(DateTime.Today.TimeOfDay.Seconds);
            car.Vehicle_Identification_Number = vin;
            var doc = this.GetDocument();
            doc.Element("Cars").Add(ToXElement(car));
            doc.Save(GetPath());

            return vin;
        }

        public void Edit(Car car)
        {
            var doc = GetDocument();
            var nodeToEdit = doc.Descendants("Car").Where(node => node.Element("Vehicle_Identification_Number").Value == car.Vehicle_Identification_Number).SingleOrDefault();
            nodeToEdit.ReplaceWith(ToXElement(car));
            doc.Save(GetPath());
        }

        public void Delete(Car car)
        {
            var doc = GetDocument();
            var nodeToDelete = doc.Descendants("Car").Where(node => node.Element("Vehicle_Identification_Number").Value == car.Vehicle_Identification_Number).SingleOrDefault();
            nodeToDelete.Remove();
            doc.Save(GetPath());
        }
    }
}