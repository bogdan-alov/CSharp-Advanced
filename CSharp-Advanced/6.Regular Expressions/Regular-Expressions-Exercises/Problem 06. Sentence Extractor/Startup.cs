using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_06.Sentence_Extractor
{
	class Startup
	{
		static void Main(string[] args)
		{
			var keyWord = Console.ReadLine();
			var text = Console.ReadLine();
			var regex = new Regex("(.+?[!.?])");
			var matches = regex.Matches(text);

			foreach (Match match in matches)
			{
				var result = match.ToString().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();

				foreach (var word in result)
				{
					if (word.Equals(keyWord))
					{
						Console.WriteLine(match);
						break;
					}
				}
			}

		}
	}
}
