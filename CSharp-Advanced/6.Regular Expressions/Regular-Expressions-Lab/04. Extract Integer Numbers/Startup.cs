using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Extract_Integer_Numbers
{
	class Startup
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			var pattern = "\\d+";
			var regex = new Regex(pattern);
			var matches = regex.Matches(input);

			foreach (Match match in matches)
			{
				Console.WriteLine(match);
			}
		}
	}
}
