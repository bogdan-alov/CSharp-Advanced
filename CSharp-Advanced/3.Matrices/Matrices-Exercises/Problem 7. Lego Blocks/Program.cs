using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Lego_Blocks
{
	class Program
	{
		static void Main(string[] args)
		{
			var rows = int.Parse(Console.ReadLine());
			var first = new int[rows][];
			var second = new int[rows][];
			var firstCells = 0;
			var secondCells = 0;
			var concatinatedMatrix = new int[rows][];
			for (int i = 0; i < rows; i++)
			{
				var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
				first[i] = input;
				firstCells += input.Length;


			}
			for (int i = 0; i < rows; i++)
			{
				var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
				second[i] = input;
				secondCells += input.Length;
			}
			var lenghtRow = 0;
			for (int row = 0; row < rows; row++)
			{

				var currentRowLenght = first[row].Length + second[row].Length;
				concatinatedMatrix[row] = new int[lenghtRow];
				if (lenghtRow == 0)
				{
					lenghtRow = currentRowLenght;
				}
				else
				{
					if (lenghtRow != currentRowLenght)
					{
						Console.WriteLine($"The total number of cells is: {firstCells + secondCells}");
						break;
					}
					else
					{
						for (int rowIndex = 0; rowIndex < rows; rowIndex++)
						{
							concatinatedMatrix[rowIndex] = new int[lenghtRow];

							for (int i = 0; i < first[rowIndex].Length + second[rowIndex].Length; i++)
							{
								if (i < first[rowIndex].Length)
								{
									concatinatedMatrix[rowIndex][i] = first[rowIndex][i];
								}
								else
								{
									concatinatedMatrix[rowIndex][i] = second[rowIndex][i - first[rowIndex].Length];
								}
							}
						}

					}

				}
			}

			if (concatinatedMatrix[1].Length == first[1].Length + second[1].Length)
			{
				foreach (var var in concatinatedMatrix)
				{
					Console.WriteLine("[" + string.Join(", ", var) + "]");
				}
			}

		}
	}
}
