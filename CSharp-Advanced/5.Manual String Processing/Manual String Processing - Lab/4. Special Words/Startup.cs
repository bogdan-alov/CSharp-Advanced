using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Special_Words
{
	class Startup
	{
		static void Main(string[] args)
		{
			var specialWords = Console.ReadLine().Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
			
			var words = new Dictionary<string, int>();
			foreach (var special in specialWords)
			{
				words.Add(special, 0);
			}
			var separators = new char[] {'(', ')', '[', ']', '<', '>', ',', '-', '!', '?', ' '};
			var text = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToArray();

			foreach (var word in text)
			{
				if (specialWords.Contains(word))
				{
					if (words.ContainsKey(word))
					{
						words[word]++;
					}
				}

			}
			foreach (var word in words)
			{
				Console.WriteLine($"{word.Key} - {word.Value}");
			}
		}
	}
}
