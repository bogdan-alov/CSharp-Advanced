using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Count_Substring_Occurrences
{
	class Startup
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine().ToLower();
			var text = Console.ReadLine().ToLower();
			int counter = 0;
			int index = input.IndexOf(text);
			while (index != -1)
			{
				counter++;
				index = input.IndexOf(text, index + 1);
			}
			Console.WriteLine(counter);
		}
	}
}
