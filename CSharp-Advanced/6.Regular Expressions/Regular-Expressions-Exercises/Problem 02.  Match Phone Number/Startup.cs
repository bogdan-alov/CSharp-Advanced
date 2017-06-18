using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_02.Match_Phone_Number
{
	class Startup
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			var pattern = "^\\+359(\\s|-)\\d\\1\\d{3}\\1\\d{4}$";
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
