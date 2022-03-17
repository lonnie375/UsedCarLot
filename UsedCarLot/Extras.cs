using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedCarLot
{
	public class Extras : Car
	{
		public string addCar { get; set; }
		public string quitCar { get; set; }

		public Extras()
		{
			this.addCar = addCar;
			this.quitCar = quitCar;
		}

		public Extras(string addCar, string quitCar)
		{

		}
	}
}
