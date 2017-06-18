using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Matrix_of_Palindromes
{
	class Startup
	{
		static void Main(string[] args)
		{
			// row % 3 = 0 , 1, 2

			var input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
			var array = new string[input[0]][];
			char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
			for (int row = 0; row < array.Length; row++)
			{
				array[row] = new string[input[1]];
				array[row][0] = $"{alphabet[row]}{alphabet[row]}{alphabet[row]}";
				for (int col = 1; col < array[row].Length; col++)
				{
					int currentChar = array[row][col - 1][1] + 1;

					array[row][col] = $"{alphabet[row]}{(char)currentChar}{alphabet[row]}";
				}
			}
			foreach (var s in array)
			{
				Console.WriteLine(string.Join(" ", s));
			}
		}
	}
}
