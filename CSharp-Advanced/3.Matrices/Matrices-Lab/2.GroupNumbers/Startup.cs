using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.GroupNumbers
{
	class Startup
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine().Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
			var array = new int[3][];
			var zero = input.Where(c => Math.Abs(c) % 3 == 0).ToArray();
			var one = input.Where(c => Math.Abs(c) % 3 == 1).ToArray();
			var two = input.Where(c => Math.Abs(c) % 3 == 2).ToArray();

			Console.WriteLine(string.Join(" ", zero));
			Console.WriteLine(string.Join(" ", one));
			Console.WriteLine(string.Join(" ", two));
		}
	}
}
