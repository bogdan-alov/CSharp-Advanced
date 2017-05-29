using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Basic_Queue_Operations
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


			var queue = new Queue<int>();

			foreach (var number in arrayNumber)
			{
				queue.Enqueue(number);
			}


			while (s != 0)
			{
				queue.Dequeue();

				s--;
			}
			if (queue.Count == 0)
			{
				Console.WriteLine(0);
			}
			else
			{
				if (queue.Contains(x))
				{
					Console.WriteLine("true");
				}
				else
				{
					var smallestNumber = queue.Min();
					Console.WriteLine(smallestNumber);
				}
			}
		}
	}
}
