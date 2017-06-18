using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Find_and_Sum_integers
{
	class Startup
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine().Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);
			var numbers = new List<long>();
			long number;
			if (input.Any(c=> long.TryParse(c, out number)))
			{
				foreach (var t in input)
				{
					long result = 0;
					if (long.TryParse(t, out result))
					{
						numbers.Add(result);
					}
				}
				Console.WriteLine(numbers.Sum());
			}
			else
			{
				Console.WriteLine("No match");
			}
			
		}
	}
}
