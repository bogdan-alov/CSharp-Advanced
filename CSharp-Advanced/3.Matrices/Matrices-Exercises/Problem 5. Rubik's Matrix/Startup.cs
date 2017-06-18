using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Rubik_s_Matrix
{
	class Startup
	{
		public static int rows = 0;
		public static int cols = 0;
		static void Main(string[] args)
		{
			var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
			var matrix = new int[input[0]][];
			var commands = int.Parse(Console.ReadLine());
			rows = input[0];
			cols = input[1];
			FillUpTheMatrix(matrix, input);
			var newMatrix = matrix;
			for (int i = 0; i < commands; i++)
			{
				var input1 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
				if (input1[1] == "right" || input1[1] == "left")
				{
					RightOrLeftCommand(input1, matrix);
				}
				else if (input1[1] == "up" || input1[1] == "down")
				{
					UpOrDownCommand(input1, matrix);
				}
			}
			ReArrangeMatrix(matrix, newMatrix);
		}

		private static void ReArrangeMatrix(int[][] matrix, int[][] newMatrix)
		{
			for (int row = 0; row < matrix.Length; row++)
			{
				for (int col = 0; col < matrix[row].Length; col++)
				{

					int initValue = row * cols + (col + 1);
					int currentValue = matrix[row][col];

					if (initValue != currentValue)
					{
						for (int k = 0; k < rows; k++)
						{
							var currentRow = matrix[k];
							int index = Array.IndexOf(currentRow, initValue);
							if (index > -1)
							{
								matrix[k][index] = currentValue;
								matrix[row][col] = initValue;
								Console.WriteLine($"Swap ({row}, {col}) with ({k}, {index})");
								break;
							}
						}
					}
					else
					{
						Console.WriteLine("No swap required");
					}
				}
			}
		}

		private static void UpOrDownCommand(string[] input1, int[][] matrix)
		{
			var moves = int.Parse(input1[2]);
			var line = int.Parse(input1[0]);
			var direction = input1[1];
			
			int m = (int)(moves % cols);
			var colValues = new Queue<int>();

			if (direction == "down")
			{
				for (int i = rows - 1; i >= 0; i--)
				{
					colValues.Enqueue(matrix[i][line]);
				}
			}
			else
			{
				for (int i = 0; i < rows; i++)
				{
					colValues.Enqueue(matrix[i][line]);
				}
			}
			for (int i = 0; i < m; i++)
			{
				int t = colValues.Dequeue();
				colValues.Enqueue(t);
			}
			if (direction == "down")
			{
				for (int i = rows - 1; i >= 0; i--)
				{
					matrix[i][line] = colValues.Dequeue();
				}
			}
			else
			{
				for (int i = 0; i < rows; i++)
				{
					matrix[i][line] = colValues.Dequeue();
				}
			}
			
		}

		private static void RightOrLeftCommand(string[] input1, int[][] matrix)
		{
			var colValues = new Queue<int>();
			int m = int.Parse(input1[2]) % cols;
			if (input1[1] == "right")
			{
				for (int i = cols - 1; i >= 0; i--)
				{
					colValues.Enqueue(matrix[int.Parse(input1[0])][i]);
				}
			}
			else
			{
				for (int i = 0; i < cols; i++)
				{
					colValues.Enqueue(matrix[int.Parse(input1[0])][i]);
				}
			}
			for (int i = 0; i < m; i++)
			{
				colValues.Enqueue(colValues.Dequeue());
			}
			if (input1[1] == "right")
			{
				for (int i = cols - 1; i >= 0; i--)
				{
					matrix[int.Parse(input1[0])][i] = colValues.Dequeue();
				}
			}
			else
			{
				for (int i = 0; i < cols; i++)
				{
					matrix[int.Parse(input1[0])][i] = colValues.Dequeue();
				}
			}
			

		}


		

		private static void FillUpTheMatrix(int[][] matrix, int[] input)
		{
			var lastElement = 0;
			for (int row = 0; row < matrix.Length; row++)
			{
				matrix[row] = new int[input[1]];
				for (int col = 0; col < matrix[row].Length; col++)
				{
					lastElement += 1;
					matrix[row][col] = lastElement;
				}
			}
		}
	}
}
