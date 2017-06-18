using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Target_Practice
{
	
	class Startup
	{
		private static int rows = 0;
		private static int cols = 0;
		private static char[][] matrix = new char[1][];
		static void Main(string[] args)
		{
			var dimensions = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
				.ToArray();
			rows = dimensions[0];
			cols = dimensions[1];
			matrix = new char[rows][];
			
			var snake = Console.ReadLine();
			var shot = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
				.ToArray();

			FillTheMatrix(snake);
			Shoot(shot);
		}

		private static void Shoot(int[] shot)
		{
			var impactRow = shot[0];
			var impactColumn = shot[1];
			var radius = shot[2];
		}

		private static void FillTheMatrix(string snake)
		{
			var currentRow = 1;
			var lastElement = 0;
			for (int row = rows - 1; row >= 0; row--)
			{
				matrix[row] = new char[cols];
				if (currentRow % 2 != 0)
				{
					for (int col = cols - 1; col >= 0; col--)
					{
						if (col == cols - 1)
						{
							var element =snake[lastElement].ToString().ToUpper();
							matrix[row][col] = element[0];
						}
						else
						{
							matrix[row][col] = snake[lastElement];
						}
						lastElement++;

						if (lastElement == snake.Length)
						{
							lastElement = 0;
						}
						if (col == 0)
						{
							currentRow++;
						}
					}
				}
				else
				{
					for (int i = 0; i < cols; i++)
					{
						
						
						if (i == cols - 1)
						{
							var element = snake[lastElement].ToString().ToUpper();
							matrix[row][i] = element[0];
						}
						else
						{
							matrix[row][i] = snake[lastElement];
						}
						lastElement++;
						if (lastElement == snake.Length)
						{
							lastElement = 0;
						}
						if (i == cols - 1)
						{
							currentRow++;
						}
					}
				}
				
			}
		}
	}
}
