using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Nature_s_Prophet
{
	class Startup
	{
		private static int rows = 0;
		private static int cols = 0;
		static void Main(string[] args)
		{
			var dimensions = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

			rows = dimensions[0];
			cols = dimensions[1];
			var matrix = new int[rows][];
			for (int i = 0; i < rows; i++)
			{
				matrix[i] = new int[cols];
				for (int j = 0; j < cols; j++)
				{
					matrix[i][j] = 0;
				}
			}
			var flowerPlace = Console.ReadLine();
			while (flowerPlace != "Bloom Bloom Plow")
			{
				var array = flowerPlace.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
				var row = array[0];
				var col = array[1];
				for (int i = 0; i < cols; i++)
				{
					matrix[row][i] += 1;
				}
				for (int i = 0; i < rows; i++)
				{
					if (i == row)
					{
						
					}
					else
					{
						matrix[i][col]++;
					}
					
				}
				
				flowerPlace = Console.ReadLine();
			}

			foreach (var i in matrix)
			{
				Console.WriteLine(string.Join(" ", i));
			}
		}
	}
}
