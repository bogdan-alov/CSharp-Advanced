using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_08.Raw_Data
{
	class Car
	{

		public Car()
		{
			this.Tires = new List<Tire>(4);
			this.Engine = new Engine();
			this.Cargo = new Cargo();
		}
		public string Model { get; set; }

		public Engine Engine { get; set; }

		public Cargo Cargo { get; set; }

		public List<Tire> Tires { get; set; }

	}
}
