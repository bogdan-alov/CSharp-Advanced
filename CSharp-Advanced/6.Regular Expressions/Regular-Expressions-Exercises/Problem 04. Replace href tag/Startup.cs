using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_04.Replace_href_tag
{
	class Startup
	{
		static void Main(string[] args)
		{
			var line = Console.ReadLine();
			var lines = new List<string>();
			var regex = new Regex(@"<a\s(href="".+?"")>(.+?)<\/a>");

			while (line != "end")
			{
				if (regex.IsMatch(line))
				{
					var match = regex.Match(line);
					var result = match.ToString();
					var spaces = line.Substring(0, line.Length - result.Length);

					result = result.Replace("<a ", "[URL ");
					result = result.Replace(">", "]");
					result = result.Replace("</a", "[/URL");
					line = spaces + result;
					
				}

				lines.Add(line);
				line = Console.ReadLine();
			}

			foreach (var lineToprint in lines)
			{
				Console.WriteLine(lineToprint);
			}
		}
	}
}
