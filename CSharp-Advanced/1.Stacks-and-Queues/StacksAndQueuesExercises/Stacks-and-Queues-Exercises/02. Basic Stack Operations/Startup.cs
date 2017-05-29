using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Basic_Stack_Operations
{
	class Startup
	{
		static void Main()
		{
			var readNumbers = Console.ReadLine();
			int[] arrayNumbers = readNumbers.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();


			int n = arrayNumbers[0];
			int s = arrayNumbers[1];
			int x = arrayNumbers[2];


			var readNumber = Console.ReadLine();
			int[] arrayNumber = readNumber.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();


			var stack = new Stack<int>();

			foreach (var number in arrayNumber)
			{
				stack.Push(number);
			}


			while (s != 0)
			{
				stack.Pop();

				s--;
			}
			if (stack.Count == 0)
			{
				Console.WriteLine(0);
			}
			else
			{
				if (stack.Contains(x))
				{
					Console.WriteLine("true");
				}
				else
				{
					var smallestNumber = stack.Min();
					Console.WriteLine(smallestNumber);
				}
			}



		}
	}
}
