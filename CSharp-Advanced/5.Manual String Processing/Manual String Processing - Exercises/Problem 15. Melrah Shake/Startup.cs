using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_15.Melrah_Shake
{
	class Startup
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			var pattern = Console.ReadLine();

			var regex = new Regex(pattern);
	
			while (true)
			{
				var matches = regex.Matches(input);

				if (matches.Count < 2 || pattern.Length == 0)
				{
					break;
				}

				var firstIndex = input.IndexOf(pattern);
				input = input.Remove(firstIndex, pattern.Length);
				var lastIndex = input.LastIndexOf(pattern);
				input = input.Remove(lastIndex, pattern.Length);

				pattern = pattern.Remove(pattern.Length / 2, 1);

				regex = new Regex(pattern);

				Console.WriteLine("Shaked it.");
			}
			Console.WriteLine("No shake.");
			Console.WriteLine(input);
			

			

		}
	}
}
