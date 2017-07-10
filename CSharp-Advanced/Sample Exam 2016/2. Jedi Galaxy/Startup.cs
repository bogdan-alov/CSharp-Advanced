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
			var count = 0;
			for (int row = 0; row < rows; row++)
			{
				matrix[row] = new int[cols];
				for (int col = 0; col < matrix[row].Length; col++)
				{
					matrix[row][col] = count;
					count++;
				}
			}
			var ivoNumbers = new List<int>();
			while (true)
			{
				var input = Console.ReadLine();
				if (input == "Let the Force be with you")
				{
					break;
				}
				var ivo = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
				
				
				
				
				var evilForce = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
				var ivoRow = ivo[0];
				var ivoCol = ivo[1];

				var evilForceRow = evilForce[0];
				var evilForceCol = evilForce[1];

				if (evilForceRow < 0 )
				{
					evilForceRow = 0;
				}
				else if (evilForceRow >= matrix.Length)
				{
					evilForceRow = matrix.Length - 1;
				}
				else if (evilForceRow == matrix.Length - 1)
				{
					evilForceRow = matrix.Length - 2;
				}

				if (evilForceCol < 0)
				{
					evilForceCol = 0;
				}
				else if (evilForceCol >= matrix[rows -1 ].Length)
				{
					evilForceCol = matrix[rows - 1].Length - 1;
				}
				else if (evilForceCol == matrix[rows - 1].Length - 1)
				{
					evilForceCol = matrix[rows - 1].Length - 2;
				}



				if (ivoRow < 0)
				{
					ivoRow = 0;
				}
				else if (ivoRow >= matrix.Length)
				{
					ivoRow = matrix.Length - 1;
				}
				else if (ivoRow == matrix.Length - 1)
				{
					ivoRow = matrix.Length - 2;
				}

				if (ivoCol < 0)
				{
					ivoCol = 0;
				}
				else if (ivoCol >= matrix[rows- 1].Length)
				{
					ivoCol = matrix[rows -1].Length - 1;
				}
				else if (ivoCol == matrix[rows - 1].Length - 1)
				{
					ivoCol = matrix[rows - 1].Length - 2;
				}

				for (int i = evilForceRow; i >= 0; i--)
				{
					if (i == evilForceRow )
					{
						matrix[i][evilForceCol] = 0;
					}
					else
					{
						matrix[i][evilForceCol - 1] = 0;
						evilForceCol = evilForceCol - 1;
					}	
				}

				for (int i = ivoRow; i >= 0; i--)
				{
					if (i == ivoRow)
					{
						ivoNumbers.Add(matrix[i][ivoCol]);
					}
					else
					{
						ivoCol = ivoCol + 1;
						ivoNumbers.Add(matrix[i][ivoCol]);
						
					}
				}
			}



			Console.WriteLine(ivoNumbers.Sum());

		}
	}
}
