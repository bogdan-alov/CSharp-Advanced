using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3.Jedi_Code_X
{
	class Program
	{
		static void Main(string[] args)
		{
			var pattern = "pattern1([a-zA-Z]{p1lenght})[^a-zA-Z]|pattern2([a-zA-Z]{p2lenght})[^a-zA-Z]";

			var n = int.Parse(Console.ReadLine());
			var text = "";
			for (int i = 0; i < n; i++)
			{
				var input = Console.ReadLine();
				text += input + " ";

			}

			var pattern1 = Console.ReadLine();
			var pattern2 = Console.ReadLine();
			pattern = pattern.Replace("pattern1", pattern1);
			pattern = pattern.Replace("p1lenght", pattern1.Length.ToString());

			pattern = pattern.Replace("pattern2", pattern2);
			pattern = pattern.Replace("p2lenght", pattern2.Length.ToString());

			var matches = Regex.Matches(text, pattern);
			var matchesG1 = new List<string>();
			var matchesG2 = new List<string>();
			foreach (Match match in matches)
			{
				if (match.Groups[1].Value != "")
				{
					matchesG1.Add(match.Groups[1].Value);
				}
				if (match.Groups[2].Value != "")
				{
					matchesG2.Add(match.Groups[2].Value);
				}
			}

			var numbers = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
				.ToArray();
			var counter = 0;
			foreach (var match in matchesG1)
			{
				if (counter >= numbers.Length)
				{
					counter = numbers.Length - 1;
				}
				if (counter < numbers.Length - 1)
				{
					counter++;
				}
				Console.WriteLine($"{match} - {matchesG2[numbers[counter]]}");
				
			}
			Console.WriteLine();
		}
	}
}
