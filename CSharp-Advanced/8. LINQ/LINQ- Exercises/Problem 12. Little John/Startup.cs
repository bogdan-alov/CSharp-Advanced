using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_12.Little_John
{
	class Startup
	{
		static void Main(string[] args)
		{
			var input = "";
			var text = new List<string>();
			for (int i = 0; i < 4; i++)
			{
				input = Console.ReadLine();
				text.Add(input);
			}
			var patternForArrows = "(>>>----->>)|(>>----->)|(>----->)";
			var smallArrows = 0;
			var mediumArrows = 0;
			var largeArrows = 0;

			foreach (var sentence in text)
			{
				var matches = Regex.Matches(sentence, patternForArrows);

				foreach (Match match in matches)
				{
					if (match.Groups[1].Success)
					{
						largeArrows += 1;
					}
					else if (match.Groups[2].Success)
					{
						mediumArrows += 1;
					}
					else
					{
						smallArrows += 1;
					}
				}
			}

			var number = $"{smallArrows}{mediumArrows}{largeArrows}";
			var numberToBinary = Convert.ToString(Convert.ToInt32(number, 10), 2);
			var reversed = Reverse(numberToBinary);
			var wholeNumber = numberToBinary + reversed;
			var result = Convert.ToInt32(wholeNumber, 2).ToString();
			Console.WriteLine(result);
		}
		public static string Reverse(string s)
		{
			char[] charArray = s.ToCharArray();
			Array.Reverse(charArray);
			return new string(charArray);
		}
	}
}
