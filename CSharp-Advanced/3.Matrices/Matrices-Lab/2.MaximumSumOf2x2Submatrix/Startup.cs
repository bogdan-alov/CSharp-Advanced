using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.MaximumSumOf2x2Submatrix
{
	class Startup
	{
		static void Main(string[] args)
		{
			var matrixSize = Console.ReadLine().Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries).ToArray();
			int[][] matrix = new int[int.Parse(matrixSize[0])][];

			for (int rows = 0; rows < matrix.Length; rows++)
			{
				matrix[rows] = Console.ReadLine().Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
			}
			var maxSquareRow = 0;
			var maxSquareCol = 0;
			var maxSum = 0;
			for (int row = 0; row < matrix.Length - 1; row++)
			{
				for (int column = 0; column < matrix[row].Length - 1; column++)
				{
					var topLeft = matrix[row][column];
					var topRight = matrix[row][column + 1];
					var bottomLeft = matrix[row + 1][column];
					var bottomRight = matrix[row + 1][column + 1];
					var currentSum = topLeft + topRight + bottomLeft  + bottomRight ;
					if (currentSum > maxSum)
					{
						maxSum = currentSum;
						maxSquareRow = row;
						maxSquareCol = column;
					}
				}
			}

			Console.WriteLine($"{matrix[maxSquareRow][maxSquareCol]} {matrix[maxSquareRow][maxSquareCol+1]}\n{matrix[maxSquareRow+1][maxSquareCol]} {matrix[maxSquareRow+1][maxSquareCol+1]}\n{maxSum}");
		}
	}
}
