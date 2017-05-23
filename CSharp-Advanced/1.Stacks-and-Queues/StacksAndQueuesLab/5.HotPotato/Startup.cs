using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.HotPotato
{
	class Startup
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			var array = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
			var n = int.Parse(Console.ReadLine());
			var queue = new Queue<string>(array);

			while (queue.Count != 1)
			{
				for (int i = 1; i < n; i++)
				{
					queue.Enqueue(queue.Dequeue());
				}
				Console.WriteLine($"Removed {queue.Dequeue()}");
			}
			Console.WriteLine($"Last is {queue.Dequeue()}");
		}

		
	}
}
