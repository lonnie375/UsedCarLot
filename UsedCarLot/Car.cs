using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
namespace UsedCarLot
{
	public class Car
	{
		public string make { get; set; }
		public string model { get; set; }
		public int year { get; set; }
		public decimal price { get; set; }

		public Car()
		{
			this.make = make;
			this.model = model;
			this.year = year;
			this.price = price;
		}

		public Car(string make, string model, int year, decimal price)
		{

		}

		public override string ToString()
		{
			return make + model + year + price;
		}
	}
}

