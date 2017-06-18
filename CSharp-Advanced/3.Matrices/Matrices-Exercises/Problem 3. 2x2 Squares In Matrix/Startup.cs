using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3._2x2_Squares_In_Matrix
{
	class Startup
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
				.ToArray();
			var matrix = new char[input[0]][];
			for (int row = 0; row < input[0] ; row++)
			{
				matrix[row] = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
			}
			var counter = 0;
			for (int row = 0; row < matrix.Length - 1; row++)
			{
				for (int column = 0; column < matrix[row].Length - 1; column++)
				{
					var topLeft = matrix[row][column];
					var topRight = matrix[row][column + 1];
					var bottomLeft = matrix[row + 1][column];
					var bottomRight = matrix[row + 1][column + 1];
					if (topLeft == topRight && topRight== bottomLeft && bottomLeft == bottomRight)
					{
						counter++;
					}
				}
			}
			Console.WriteLine(counter);
		}
	}
}
