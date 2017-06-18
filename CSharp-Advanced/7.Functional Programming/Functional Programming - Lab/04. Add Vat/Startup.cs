using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Add_Vat
{
	class Startup
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine().Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse)
				.Select(c => c += c * 0.2).ToList();
			input.ForEach(c => Print(c));
		}

		private static void Print(double d)
		{
			Console.WriteLine($"{d:f2}");
		}
	}
}
