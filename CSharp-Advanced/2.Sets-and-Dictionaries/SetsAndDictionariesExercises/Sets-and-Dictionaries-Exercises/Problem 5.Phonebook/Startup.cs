using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Phonebook
{
	class Startup
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			var dictionary = new Dictionary<string,string>();
			while (input != "search")
			{
				var array = input.Split(new[] {'-'}, StringSplitOptions.RemoveEmptyEntries).ToArray();

				if (array.Length == 2)
				{
					if (!dictionary.ContainsKey(array[0]))
					{
						dictionary.Add(array[0], array[1]);
					}
					else
					{
						dictionary[array[0]] = array[1];
					}
				}
				input = Console.ReadLine();
			}
			var input2 = Console.ReadLine();
			while (input2 != "stop")
			{

				if (dictionary.ContainsKey(input2))
				{
					Console.WriteLine($"{input2} -> {dictionary[input2]}");
				}
				else
				{
					Console.WriteLine($"Contact {input2} does not exist.");
				}
				input2 = Console.ReadLine();
			}
		}
	}
}
