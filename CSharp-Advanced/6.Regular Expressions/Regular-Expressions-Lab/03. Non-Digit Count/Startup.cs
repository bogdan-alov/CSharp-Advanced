using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Non_Digit_Count
{
	class Startup
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			var pattern = "\\D";
			var regex = new Regex(pattern);
			var matches = regex.Matches(input);

			Console.WriteLine($"Non-digits: {matches.Count}");
		}
	}
}
