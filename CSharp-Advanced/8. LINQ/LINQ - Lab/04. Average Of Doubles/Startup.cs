using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Average_Of_Doubles
{
	class Startup
	{
		static void Main(string[] args)
		{
			var number = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse)
				.Average();
			Console.WriteLine($"{number:f2}");
		}
	}
}
