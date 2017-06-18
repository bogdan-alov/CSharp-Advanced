using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Vowel_Count
{
	class Startup
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			var pattern = "[AaIiEeUuOoYy]";
			var regex = new Regex(pattern);
			var matches = regex.Matches(input);

			Console.WriteLine($"Vowels: {matches.Count}");
		}
	}
}
