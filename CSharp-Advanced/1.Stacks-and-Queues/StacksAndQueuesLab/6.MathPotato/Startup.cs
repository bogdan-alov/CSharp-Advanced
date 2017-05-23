using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.MathPotato
{
	class Startup
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			var array = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
			var n = int.Parse(Console.ReadLine());
			var queue = new Queue<string>(array);
			var cycle = 1;
			while (queue.Count != 1)
			{
				for (int i = 1; i < n; i++)
				{
					queue.Enqueue(queue.Dequeue());
				}

				if (IsPrimeNumber(cycle))
				{
					Console.WriteLine($"Prime {queue.Peek()}");
				}
				else
				{
					Console.WriteLine($"Removed {queue.Dequeue()}");
				}
				cycle++;
			}
			Console.WriteLine($"Last is {queue.Dequeue()}");
		}
		public static bool IsPrimeNumber(int number)
		{
			if (number == 1) return false;
			if (number == 2) return true;

			for (int i = 2; i <= Math.Ceiling(Math.Sqrt(number)); ++i)
			{
				if (number % i == 0) return false;
			}
			return true;
		}
	}
}
