using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10.Car_Salesman
{
	class Car
	{
		public Car()
		{
			this.Weight = "n/a";
			this.Color = "n/a";
		}
		public string Model { get; set; }

		public Engine Engine { get; set; }

		public string Weight { get; set; }

		public string Color { get; set; }

		public override string ToString()
		{

			
			
			return $"{Model}:\n  {Engine.Model}:\n    Power: {Engine.Power}\n    Displacement: {Engine.Displacement}\n    Efficiency: {Engine.Efficiency}\n  Weight: {Weight}\n  Color: {Color}";
		}
	}
}
