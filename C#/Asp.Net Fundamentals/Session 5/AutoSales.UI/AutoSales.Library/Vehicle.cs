using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoSales.Library
{
    public class Vehicle
    {
        private string _make;
        private decimal _price;
        public uint _year;


        public ColorEnum Color { get; set; }
        public string Make
        {
            get
            {
                return _make;
            }
            set
            {
                if (value != null && value.Length > 0)
                    _make = value;
                else
                    throw new ApplicationException("Make cannot be empty");
            }
        }
        public string Model { get; set; }
        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value >= 1 && value <= 100000)
                    _price = value;
                else
                    throw new ApplicationException("Price must be between $1 and $100,000");
            }
        }
        public uint Year 
        {
            get
            {
                return _year;
            }
            set
            {
                if (value >= 1900 && value <= DateTime.Today.Year)
                _year = value;
                else
                    throw new ApplicationException("Year must be between 1900 and this Year");
            }
        }

        public Vehicle()
        {
            Color = ColorEnum.Red;
            Make = "Porsche";
            Model = "Cayenne";
            Price = 5000M;
            Year = Convert.ToUInt16(DateTime.Today.Year);
        }
        public Vehicle(ColorEnum vehicleColor)
        {
            Color = vehicleColor;
        }
    }

}
