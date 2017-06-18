using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_01.Match_Full_Name
{
	class Startup
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			var pattern = "^[A-Z][a-z]+\\s[A-Z][a-z]+$";
			var regex = new Regex(pattern);
			while (input != "end")
			{
				var match = regex.Match(input);
				if (match.Success)
				{
					Console.WriteLine(match);
				}
				input = Console.ReadLine();
			}

		}
	}
}
