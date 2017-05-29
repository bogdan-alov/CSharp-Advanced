using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Truck_Tour
{
	class Startup
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var petrolStations = new Queue<int[]>();
			int index = 0;
			for (int i = 0; i < n; i++)
			{
				var input = Console.ReadLine();
				var array = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
				petrolStations.Enqueue(array);

			}

			var reachFinal = false;

			while (!reachFinal)
			{
				var totalPetrol = 0;

				for (int i = 0; i <= n; i++)
				{
					if (i == n)
					{
						
						reachFinal = true;
						break;
					}
					var petrolStation = petrolStations.Dequeue();
					petrolStations.Enqueue(petrolStation);

					totalPetrol += petrolStation[0] - petrolStation[1];
					if (totalPetrol < 0)
					{
						index += i + 1;
						break;
					}
				}
			}
			Console.WriteLine(index);
		}
	}
}
