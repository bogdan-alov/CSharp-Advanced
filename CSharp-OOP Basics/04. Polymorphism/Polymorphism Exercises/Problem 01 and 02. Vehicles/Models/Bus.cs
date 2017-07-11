using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01_and_02.Vehicles.Models
{
	class Bus : Vehicle
	{
		public Bus(double fuel, double fuelPerKM, double tankCapacity) : base(fuel, fuelPerKM, tankCapacity)
		{
		}

		public override void Drive(double distance)
		{
			FuelPerKM += 1.4;
			var fuelNeeded = distance * FuelPerKM;
			if (Fuel < fuelNeeded)
			{
				Console.WriteLine("Bus needs refueling");
			}
			else
			{
				Fuel -= distance * FuelPerKM;
				Console.WriteLine($"Bus travelled {distance} km");
			}
			FuelPerKM -= 1.4;
		}

		public void DriveEmpty(double distance)
		{
			var fuelNeeded = distance * FuelPerKM;
			if (Fuel < fuelNeeded)
			{
				Console.WriteLine("Bus needs refueling");
			}
			else
			{
				Fuel -= distance * FuelPerKM;
				Console.WriteLine($"Bus travelled {distance} km");
			}
		}
		public override void Refuel(double fuel)
		{
			if (fuel <= 0)
			{
				Console.WriteLine("Fuel must be a positive number");
			}
			else if (Fuel + fuel > TankCapacity)
			{
				Console.WriteLine("Cannot fit fuel in tank");
			}
			else
			{
				Fuel += fuel;

			}
		}
	}
}
