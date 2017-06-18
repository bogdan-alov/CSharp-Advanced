using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SumNumbers
{
	class Startup
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine().Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
			Console.WriteLine(input.Count);
			Console.WriteLine(input.Sum());
		}
	}
}
