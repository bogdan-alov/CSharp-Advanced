using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SumOfAllElementsInMatrix
{
	class Startup
	{
		static void Main(string[] args)
		{
			var matrixSize = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
			int[][] matrix = new int[int.Parse(matrixSize[0])][];

			for (int rows = 0; rows < matrix.Length; rows++)
			{
				matrix[rows] = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
			}
			var sum = 0;
			for (int row = 0; row < matrix.Length; row++)
			{
				sum += matrix[row].Sum();
			}
			Console.WriteLine(matrix.Length);
			Console.WriteLine(matrix[0].Length);
			Console.WriteLine(sum);
		}
	}
}
