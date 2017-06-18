using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_05.Extract_Email
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();

			var pattern =
				@"(([^<>()\[\]\\.,;:\s@""]+(\.[^<>()\[\]\\.,;:\s@""]+)*)|("".+""))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))";


			var regex = new Regex(pattern);
			var matches = regex.Matches(input);

			foreach (Match match in matches)
			{
				if (match.ToString().StartsWith("-") || match.ToString().StartsWith("_") || match.ToString().StartsWith(".") || match.Groups[1].ToString().EndsWith("_") || match.Groups[1].ToString().EndsWith(".") || match.Groups[1].ToString().EndsWith("-") )
				{
					
				}
				else
				{
					Console.WriteLine(match);
				}
			}
		}
	}
}
