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
		public string used { get; set; }


        public UsedCar()
        {
			this.mileage = mileage;
			this.used = used; 
		}

		public UsedCar(string make, string model, int year, decimal price, double mileage)
        {

        }
        public override string ToString()
		{
			return make + model + year + price + used + mileage;

		}
	}
}
