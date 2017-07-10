using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lady_Bugs
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var field = new int[n];
			var indexes = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
			foreach (var index in indexes)
			{
				field[index] = 1;
			}
			var input = "";
			while ((input = Console.ReadLine()) != "end")
			{
				var array = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();

				var index = int.Parse(array[0]);
				var position = array[1];
				var moves = int.Parse(array[2]);
				if (position == "right")
				{
					field[index] = 0;
					if (moves >= 0)
					{
						if (index + moves < field.Length)
						{
							if (field[index + moves] == 1)
							{
								if (index + moves + moves < field.Length && index + moves + moves >= 0)
								{
									field[index + moves + moves] = 1;
								}

							}
						}
					}
					else
					{
						
					}
				}
				else
				{
					
				}
			}

			Console.WriteLine(string.Join(" ", field));
		}
	}
}
