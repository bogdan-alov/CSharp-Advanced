using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01_and_02.Vehicles.Models
{
	public abstract class Vehicle
	{
		public Vehicle(double fuel, double fuelPerKM, double tankCapacity)
		{
			this.Fuel = fuel;
			this.FuelPerKM = fuelPerKM;
			this.TankCapacity = tankCapacity;
		}
		private double fuel;
		private double fuelPerKM;
		private double tankCapacity;

		public double TankCapacity
		{
			get { return tankCapacity; }
			set
			{

				tankCapacity = value;
			}
		}

		public double FuelPerKM
		{
			get { return fuelPerKM; }
			set { fuelPerKM = value; }
		}

		public double Fuel
		{
			get { return fuel; }
			set
			{
				this.fuel = value;
			}
		}



		public abstract void Drive(double distance);

		public abstract void Refuel(double fuel);
	}
}
