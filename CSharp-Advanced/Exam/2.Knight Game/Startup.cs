using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Knight_Game
{
	class Startup
	{
		static void Main(string[] args)
		{
			var dimensions = int.Parse(Console.ReadLine());
			var matrix = new char[dimensions][];
			for (int i = 0; i < dimensions; i++)
			{
				matrix[i] = Console.ReadLine().ToCharArray();
			}

			var counter = 0;
			for (int i = 0; i < dimensions; i++)
			{
				
				for (int j = 0; j < dimensions; j++)
				{
					if (matrix[i][j] == 'K')
					{
						if (matrix[i + 1][j + 2] == 'K' || matrix[i + 2][j+1] == 'K')
						{
							counter++;
						}
					}
				}
			}
			//foreach (var i in matrix)
			//{
			//	Console.WriteLine(string.Join(" ", i));
			//}

			Console.WriteLine(counter);
		}
	}
}
