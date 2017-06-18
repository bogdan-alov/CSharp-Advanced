using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_09.Query_Mess
{
	class Startup
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();

			var pairs = "([^&=?]*)=([^&=]*)";
			var spaces = "((%20|\\+)+)";
			while (input != "END")
			{
				Regex pairs1 = new Regex(pairs);
				var matches = pairs1.Matches(input);
				var dictionary = new Dictionary<string, List<string>>();
				foreach (Match pair in matches)
				{
					string key = pair.Groups[1].Value;
					key = Regex.Replace(key, spaces, word => " ").Trim();

					string value = pair.Groups[2].Value;
					value = Regex.Replace(value, spaces, word => " ").Trim();
					if (!dictionary.ContainsKey(key))
					{
						dictionary.Add(key, new List<string>());
						dictionary[key].Add(value);
					}
					else
					{
						dictionary[key].Add(value);
					}
				}
				foreach (var data in dictionary)
				{
					Console.Write($"{data.Key}=[{string.Join(", ", data.Value)}]");
				}
				Console.WriteLine();
				input = Console.ReadLine();
			}
		}
	}
}

