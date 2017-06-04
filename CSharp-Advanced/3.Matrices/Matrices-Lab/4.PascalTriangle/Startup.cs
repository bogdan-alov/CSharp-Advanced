using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.PascalTriangle
{
	class Startup
	{
		static void Main(string[] args)
		{
			var height = int.Parse(Console.ReadLine());
			var jagged = new long[height][];
			for (int row = 0; row < height; row++)
			{
				jagged[row] = new long[row + 1];
				jagged[row][0] = 1;
				jagged[row][jagged[row].Length - 1] = 1;
				for (int col = 1; col < jagged[row].Length - 1; col++)
				{
					jagged[row][col] = jagged[row - 1][col - 1] + jagged[row - 1][col];
				}


			}
			foreach (var l in jagged)
			{
				Console.WriteLine(string.Join(" ", l));
			}
		}
	}
}
