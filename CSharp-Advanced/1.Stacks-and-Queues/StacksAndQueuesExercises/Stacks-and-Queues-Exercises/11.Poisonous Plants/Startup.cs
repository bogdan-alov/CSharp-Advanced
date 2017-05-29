using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _11.Poisonous_Plants
{
	class Startup
	{
		static void Main(string[] args)
		{
			var numberOfPlants = int.Parse(Console.ReadLine());
			var plants = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
			var previousPlants = new Stack<int>();
			var deaysOfPlantsDie = new int[numberOfPlants];
			previousPlants.Push(0);
			
			for (int i = 1; i < numberOfPlants; i++)
			{
				int lastDay = 0;
				while (previousPlants.Count() > 0 && plants[previousPlants.Peek()] >= plants[i])
				{
					lastDay = Math.Max(lastDay, deaysOfPlantsDie[previousPlants.Pop()]);

				}

				if (previousPlants.Count() > 0)
				{
					deaysOfPlantsDie[i] = lastDay + 1;
				}
				previousPlants.Push(i);
			}
			Console.WriteLine(deaysOfPlantsDie.Max());
		}
	}
}
