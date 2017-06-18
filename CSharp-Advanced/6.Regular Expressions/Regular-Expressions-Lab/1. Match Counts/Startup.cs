using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1.Match_Counts
{
	class Startup
	{
		static void Main(string[] args)
		{
			var pattern = Console.ReadLine();
			var text = Console.ReadLine();

			var regex = new Regex(pattern);
			var matches = regex.Matches(text);

			Console.WriteLine(matches.Count);
		}
	}
}
