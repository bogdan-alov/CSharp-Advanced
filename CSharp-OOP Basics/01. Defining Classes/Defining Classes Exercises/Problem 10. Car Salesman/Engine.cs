using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10.Car_Salesman
{
	class Engine
	{
		public Engine()
		{
			this.Displacement = "n/a";
			this.Efficiency = "n/a";
		}
		public string Model { get; set; }

		public int Power { get; set; }

		public string Displacement { get; set; }

		public string Efficiency { get; set; }
	}
}
