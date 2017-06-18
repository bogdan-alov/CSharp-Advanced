using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Maximum_Sum
{
	class Startup
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
			var matrix = new int[input[0]][];
			for (int i = 0; i < input[0]; i++)
			{
				matrix[i] = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
			}
			var maxSum = 0;
			var topLeft1 = 0;
			var topMiddle1 = 0;
			var topRight1 =0;

			var middleLeft1= 0;
			var middle1 = 0;
			var middleRight1 = 0;

			var bottomLeft1 = 0;
			var bottomMiddle1 = 0;
			var bottomRight1 =0;
			for (int row = 0; row < matrix.Length - 2; row++)
			{
				for (int column = 0; column < matrix[row].Length - 2; column++)
				{
					var topLeft = matrix[row][column];
					var topMiddle = matrix[row][column + 1];
					var topRight = matrix[row][column + 2];

					var middleLeft = matrix[row + 1][column];
					var middle = matrix[row + 1][column + 1];
					var middleRight = matrix[row + 1][column + 2];

					var bottomLeft = matrix[row + 2][column];
					var bottomMiddle = matrix[row + 2][column + 1];
					var bottomRight = matrix[row + 2][column + 2];
					var currentSum = topLeft + topMiddle + topRight + middleLeft + middle + middleRight + bottomLeft + bottomMiddle +
					                 bottomRight;
					if (currentSum > maxSum)
					{
						maxSum = currentSum;
						topLeft1 = topLeft;
						topMiddle1 = topMiddle;
						topRight1 = topRight;

						middleLeft1 = middleLeft;
						middle1 = middle;
						middleRight1 = middleRight;

						bottomLeft1 = bottomLeft;
						bottomMiddle1 = bottomMiddle;
						bottomRight1 = bottomRight;
					}
				}
			}
			Console.WriteLine($"Sum = {maxSum}");
			Console.WriteLine($"{topLeft1} {topMiddle1} {topRight1}");
			Console.WriteLine($"{middleLeft1} {middle1} {middleRight1}");
			Console.WriteLine($"{bottomLeft1} {bottomMiddle1} {bottomRight1}");
		}
	}
}
