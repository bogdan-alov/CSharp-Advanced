using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_10.Use_your_chains__Buddy
{
	class Startup
	{
		static void Main(string[] args)
		{
			var pattern = "<p>(.+?)<\\/p>";
			var patternForTags = "[^0-9a-z]";
			var patternForSpace = "[ ]+";
			var input = Console.ReadLine();
			var dictionary = new Dictionary<char,char>()
			{
				{'a', 'n'},
				{'b', 'o'},
				{'c', 'p'},
				{'d', 'q'},
				{'e', 'r'},
				{'f', 's'},
				{'g', 't'},
				{'h', 'u'},
				{'i', 'v'},
				{'j', 'w'},
				{'k', 'x'},
				{'l', 'y'},
				{'m', 'z'}
			};


			var regex = new Regex(pattern);
			var regex2 = new Regex(patternForTags);
			var regex3 = new Regex(patternForSpace);
			var matches = regex.Matches(input);
			var sb = new StringBuilder();

			foreach (Match match in matches)
			{
				var tag = match.Groups[1].Value;
				if (regex2.IsMatch(tag))
				{
					tag = Regex.Replace(tag, patternForTags, " ");
				}
				sb.Append(tag);
				
			}

			var lines = sb.ToString();
			if (regex3.IsMatch(lines))
			{
				lines = Regex.Replace(lines, patternForSpace, " ");
			}
			sb = new StringBuilder();
			sb.Append(lines);
			var result = new StringBuilder();
			for (int i = 0; i < sb.Length; i++)
			{
				result.Append(GetTrueValue(sb[i], dictionary));
			}
			Console.WriteLine(result);
		}

		private static char GetTrueValue(char c, Dictionary<char, char> dictionary)
		{
			if (dictionary.ContainsKey(c))
			{
				return c = dictionary[c];
			}
			if (dictionary.ContainsValue(c))
			{
				return c = dictionary.FirstOrDefault(x => x.Value.Equals(c)).Key;
			}
			return c;
		}
	}
}
