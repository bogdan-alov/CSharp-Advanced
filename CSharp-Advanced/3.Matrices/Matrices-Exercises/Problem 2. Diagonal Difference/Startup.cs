using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Diagonal_Difference
{
	class Startup
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var matrix = new int[n][];

			for (int row = 0; row < n; row++)
			{
				var input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
				matrix[row] = input;
			}
			var sumOfDiagonal1 = 0;
			var sumOfDiagonal2 = 0;
			var index = 1;
			for (int row = 0; row < n; row++)
			{
				sumOfDiagonal1 += matrix[row][row];
				sumOfDiagonal2 += matrix[row][n - index];
				index++;
			}

			Console.WriteLine(Math.Abs(sumOfDiagonal2 - sumOfDiagonal1));
		}
	}
}
