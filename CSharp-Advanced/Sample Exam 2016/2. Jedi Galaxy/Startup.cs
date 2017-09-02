using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Jedi_Galaxy
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
			var counter = 0;
			for (int row = 0; row < rows; row++)
			{
				matrix[row] = new int[cols];
				for (int col = 0; col < matrix[row].Length; col++)
				{
					matrix[row][col] = counter;
					counter++;
				}
			}

			var sum = 0;
			var input = string.Empty;

			while ((input = Console.ReadLine()) != "Let the Force be with you")
			{
				var jediArgs = input.Split().Select(int.Parse).ToArray();
				var evilArgs = Console.ReadLine().Split().Select(int.Parse).ToArray();

				var jediRow = jediArgs[0];
				var jediCol = jediArgs[1];
				var evilRow = evilArgs[0];
				var evilCol = evilArgs[1];

				while (evilRow >= 0 && evilCol >= 0)
				{
					if (IsMatrix(evilRow, evilCol, matrix))
					{
						matrix[evilRow][evilCol] = 0;
					}
					evilRow--;
					evilCol--;
				}

				while (jediRow >= 0 && jediCol < matrix[0].Length)
				{
					if (IsMatrix(jediRow, jediCol, matrix))
					{
						sum += matrix[jediRow][jediCol];
					}
					jediRow--;
					jediCol++;
				}
			}

			Console.WriteLine(sum);
			//foreach (var i in matrix)
			//{
			//	Console.WriteLine(string.Join(" ", i));
			//}
		}

		private static bool IsMatrix(int row, int col, int[][] matrix)
		{
			return row >= 0 && row < matrix.Length && col >= 0 && col < matrix[0].Length;
		}
	}
}
