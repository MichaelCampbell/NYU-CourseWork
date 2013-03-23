using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoDealership.Models
{
    public class CarBUS
    {
        private CarDAL DAL;

        public CarBUS()
        {
            DAL = new CarDAL();
        }

        public List<Car> GetCars()
        {
            return DAL.GetCars();
        }

        public Car GetCar(string vin)
        {
            if (vin == null)
            {
                return null;
            }

            return DAL.GetCar(vin);
        }

        public void Delete(Car car)
        {
            DAL.Delete(car);
        }

        public string Create(Car car)
        {
            return DAL.Create(car);
        }

        public void Edit(Car car)
        {
            DAL.Edit(car);
        }

    }
}