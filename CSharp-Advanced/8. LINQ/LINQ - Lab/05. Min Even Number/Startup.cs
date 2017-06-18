using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Min_Even_Number
{
	class Startup
	{
		static void Main(string[] args)
		{
			var numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList().Where(c=> c % 2 == 0).ToList();

			if (numbers.Count == 0)
			{
				Console.WriteLine("No match");
			}
			else
			{
				Console.WriteLine($"{numbers.Min():f2}");
			}

		}
	}
}
