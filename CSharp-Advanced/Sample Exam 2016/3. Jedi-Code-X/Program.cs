using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _3.Jedi_Code_X
{
	class Program
	{
		public static void Main(string[] args)
		{
			var jediNamesPattern = "pattern1([a-zA-Z]{p1lenght})[^a-zA-Z]";
			var jediMessagesPattern = "pattern2([a-zA-Z0-9]{p2lenght})[^a-zA-Z0-9]";
			var n = int.Parse(Console.ReadLine());
			var text = "";
			for (int i = 0; i < n; i++)
			{
				var input = Console.ReadLine();
				text += input + " ";

			}

			var pattern1 = Console.ReadLine();
			var pattern2 = Console.ReadLine();
			jediNamesPattern = jediNamesPattern.Replace("pattern1", Regex.Escape(pattern1));
			jediNamesPattern = jediNamesPattern.Replace("p1lenght", pattern1.Length.ToString());

			jediMessagesPattern = jediMessagesPattern.Replace("pattern2", Regex.Escape(pattern2));
			jediMessagesPattern = jediMessagesPattern.Replace("p2lenght", pattern2.Length.ToString());

			var namesMatches = Regex.Matches(text, jediNamesPattern);
			var messagesMatches = Regex.Matches(text, jediMessagesPattern);

			var jediNames = Arrange(namesMatches);
			var messages = Arrange(messagesMatches);

			var numbers = new Queue<int>(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
				.ToArray());

			foreach (var jediName in jediNames)
			{
				var number = numbers.Dequeue() - 1;

				if (number < messages.Count && number >= 0)
				{
					Console.WriteLine($"{jediName} - {messages[number]}");
				}
			}
		}

		public static List<string> Arrange(MatchCollection matches)
		{
			var list = new List<string>();

			foreach (Match match in matches)
			{
				list.Add(match.Groups[1].Value);
			}

			return list;
		}
	}
}
