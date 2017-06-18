using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Extract_Tags
{
	class Startup
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			var pattern = "<.+?>";
			while (input != "END")
			{
				var regex = new Regex(pattern);
				var matches = regex.Matches(input);
				foreach (Match match in matches)
				{
					Console.WriteLine(match);
				}
				input = Console.ReadLine();
			}
		}
	}
}
