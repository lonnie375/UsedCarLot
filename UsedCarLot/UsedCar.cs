using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedCarLot
{
	public class UsedCar : Car
	{
		public double mileage { get; set; }



		public UsedCar(string make, string model, int year, decimal price, double mileage)
        {

			this.make = make; 
			this.model = model;
			this.year = year;
			this.price = price;
			this.mileage = mileage;
		}



        public override string ToString()
		{
			return make + model + year + price +  mileage;

		}
	}
}
