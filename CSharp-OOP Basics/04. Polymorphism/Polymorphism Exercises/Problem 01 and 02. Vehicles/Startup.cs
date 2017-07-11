using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_01_and_02.Vehicles.Models;

namespace Problem_01_and_02.Vehicles
{
	class Startup
	{
		static void Main(string[] args)
		{

			var car = new Car(0, 0, 0);
			var truck = new Truck(0, 0, 0);
			var bus = new Bus(0, 0, 0);
			for (int i = 0; i < 3; i++)
			{
				var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
				if (input[0] == "Car")
				{
					car = new Car(double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3]));
				}
				else if (input[0] == "Truck")
				{
					truck = new Truck(double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3]));
				}
				else
				{
					bus = new Bus(double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3]));
				}
			}

			var n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				var commands = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
				if (commands[0] == "Drive")
				{
					if (commands[1] == "Car")
					{
						car.Drive(double.Parse(commands[2]));
					}
					else if (commands[1] == "Bus")
					{
						bus.Drive(double.Parse(commands[2]));
					}
					else
					{
						truck.Drive(double.Parse(commands[2]));
					}
				}
				else if (commands[0] == "Refuel")
				{
					if (commands[1] == "Car")
					{
						car.Refuel(double.Parse(commands[2]));
					}
					else if (commands[1] == "Bus")
					{
						bus.Refuel(double.Parse(commands[2]));
					}
					else
					{
						truck.Refuel(double.Parse(commands[2]));
					}
				}
				else
				{
					bus.DriveEmpty(double.Parse(commands[2]));
				}
			}

			Console.WriteLine($"Car: {car.Fuel:f2}");
			Console.WriteLine($"Truck: {truck.Fuel:f2}");
			Console.WriteLine($"Bus: {bus.Fuel:f2}");


		}
	}
}
