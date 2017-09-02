using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace _1.Regeh
{
	class Startup
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();

			var pattern = "[[][^ []+?<(\\d+)REGEH(\\d+)>[^ ]+?]";

			var matches = Regex.Matches(input, pattern);

			var result = string.Empty;
			var index = 0;
			foreach (Match match in matches)
			{

				var index1 = int.Parse(match.Groups[1].Value);
				var index2 = int.Parse(match.Groups[2].Value);
				index += index1;

				if (index >= input.Length)
				{
					index = (index % input.Length) + 1;
					result += input[index];
				}
				else
				{
					result += input[index];
				}

				index += index2;

				if (index >= input.Length)
				{
					index = index % input.Length + 1;
					result += input[index];
				}
				else
				{
					result += input[index];
				}

			}
	
			Console.WriteLine(result);
		}
	}
}
