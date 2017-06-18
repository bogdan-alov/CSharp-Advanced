using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Bounded_Numbers
{
	class Startup
	{
		static void Main(string[] args)
		{
			var lowerUpperBound = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			var first = lowerUpperBound[0];
			var second = lowerUpperBound[1];
			var lower = 0;
			var upper = 0;
			if (first > second)
			{
				upper = first;
				lower = second;
			}
			else
			{
				upper = second;
				lower = first;
			}

			Console.ReadLine().Split(' ').Select(int.Parse).Where(c=> c >= lower && c <= upper).ToList().ForEach(c=> Console.Write(c + " "));
		}
	}
}
