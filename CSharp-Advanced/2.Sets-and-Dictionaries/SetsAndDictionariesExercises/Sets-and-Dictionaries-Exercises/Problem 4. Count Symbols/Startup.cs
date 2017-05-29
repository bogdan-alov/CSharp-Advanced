using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Count_Symbols
{
	class Startup
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			var dictionary = new Dictionary<char,int>();

			foreach (var ch in input)
			{
				if (!dictionary.ContainsKey(ch))
				{
					dictionary.Add(ch,1);
				}
				else
				{
					dictionary[ch]++;
				}
			}

			foreach (var element in dictionary.OrderBy(c=> c.Key))
			{
				Console.WriteLine($"{element.Key}: {element.Value} time/s");
			}
		}
	}
}
