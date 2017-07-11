using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01_and_02.Vehicles.Models
{
	public class Car : Vehicle
	{
		public Car(double fuel, double fuelPerKM, double tankCapacity) : base(fuel, fuelPerKM, tankCapacity)
		{
			this.FuelPerKM += 0.9;
		}

		public override void Drive(double distance)
		{
			var fuelNeeded = distance * FuelPerKM;
			if (Fuel < fuelNeeded)
			{
				Console.WriteLine("Car needs refueling");
			}
			else
			{
				Fuel -= distance * FuelPerKM;
				Console.WriteLine($"Car travelled {distance} km");
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
