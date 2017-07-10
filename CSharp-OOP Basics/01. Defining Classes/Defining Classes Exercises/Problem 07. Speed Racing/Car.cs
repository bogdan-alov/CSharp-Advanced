using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_07.Speed_Racing
{
	class Car
	{
		public string model;
		public double fuelConsumptionPerKilometer;
		public double fuelAmount;
		public int distanceTravelled;

		public Car()
		{
			this.distanceTravelled = 0;
		}
		
		public void Drive(int distance)
		{
			var neededFuel = this.fuelConsumptionPerKilometer * distance;

			if (neededFuel > this.fuelAmount)
			{
				Console.WriteLine("Insufficient fuel for the drive");
			}

			else
			{
				this.distanceTravelled += distance;
				this.fuelAmount -= neededFuel;
			}
		}
	}
}
