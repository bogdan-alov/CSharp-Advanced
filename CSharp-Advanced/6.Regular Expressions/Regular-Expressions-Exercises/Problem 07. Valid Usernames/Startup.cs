using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_07.Valid_Usernames
{
	class Startup
	{
		static void Main(string[] args)
		{

			var pattern = "^[A-Za-z][a-zA-Z0-9_]{2,25}$";
			var regex = new Regex(pattern);

			var input = Console.ReadLine().Split(new char[] {' ', '/', '\\', '(', ')'}, StringSplitOptions.RemoveEmptyEntries).ToList();
			var matches = new List<string>();
			
			for (int i = 0; i < input.Count; i++)
			{
				
				if (regex.IsMatch(input[i]))
				{
					matches.Add(input[i]);
				}
			}
			var sum = 0;
			var first = "";
			var second = "";
			for (int i = 1; i < matches.Count; i++)
			{
				if (matches[i].Length + matches[i - 1].Length > sum)
				{
					first = matches[i- 1];
					second = matches[i];
					sum = matches[i].Length + matches[i - 1].Length;
				}
			}

			Console.WriteLine(first);
			Console.WriteLine(second);
		}
	}
}
