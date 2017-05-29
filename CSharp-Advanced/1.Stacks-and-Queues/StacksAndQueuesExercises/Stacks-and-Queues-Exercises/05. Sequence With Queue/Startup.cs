using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sequence_With_Queue
{
	class Startup
	{
		static void Main(string[] args)
		{
			long n = long.Parse(Console.ReadLine());
			var queue = new Queue<long>();
			queue.Enqueue(n);

			for (int i = 0; i < 50; i ++)
			{
				long currentElement = queue.Dequeue();
				Console.Write($"{currentElement} ");
				long firstS = currentElement + 1;
				long secondS = (currentElement * 2) + 1;
				long thirdS = currentElement + 2;


				queue.Enqueue(firstS);
				queue.Enqueue(secondS);
				queue.Enqueue(thirdS);

				
			}



		}
	}
}
