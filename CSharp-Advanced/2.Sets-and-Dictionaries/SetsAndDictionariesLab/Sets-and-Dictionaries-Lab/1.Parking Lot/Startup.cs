using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Parking_Lot
{
	class Startup
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			var parkingLot = new SortedSet<string>();
			while (input != "END")
			{
				var command = input.Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries).ToArray();

				if (command[0] == "IN")
				{
					parkingLot.Add(command[1]);
				}
				if (command[0] == "OUT")
				{
					if (parkingLot.Count == 0)
					{
						Console.WriteLine("Parking Lot is Empty");
					}
					else
					{
						parkingLot.Remove(command[1]);
					}
				}

				input = Console.ReadLine();
			}
			if (parkingLot.Count() != 0)
			{
				foreach (var car in parkingLot)
				{
					Console.WriteLine(car);
				}
			}
			else
			{
				Console.WriteLine("Parking Lot is Empty");
			}
		}
	}
}
