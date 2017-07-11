using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01_and_02.Vehicles.Models
{
	public class Truck : Vehicle
	{
		
		public Truck(double fuel, double fuelPerKM, double tankCapacity) : base(fuel, fuelPerKM, tankCapacity)
		{
			this.FuelPerKM += 1.6;
		}

		public override void Drive(double distance)
		{
			var fuelNeeded = distance * FuelPerKM;
			if (Fuel < fuelNeeded)
			{
				Console.WriteLine("Truck needs refueling");
			}
			else
			{
				Fuel -= distance * FuelPerKM;
				Console.WriteLine($"Truck travelled {distance} km");
			}
		}

		public override void Refuel(double fuel)
		{
			if (fuel <= 0)
			{
				Console.WriteLine("Fuel must be a positive number");
			}
			else
			{
				this.Fuel += fuel * 0.95;
			}
			
		}
	}
}
