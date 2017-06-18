using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Filter_By_Age
{
	class Startup
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var dictionary = new Dictionary<string,int>();
			for (int i = 0; i < n; i++)
			{
				var input = Console.ReadLine().Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries).ToArray();

				dictionary.Add(input[0], int.Parse(input[1]));
			}

			var condition = Console.ReadLine();
			var age = int.Parse(Console.ReadLine());
			var format = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
			if (condition == "younger")
			{
				if (format.Length > 1)
				{
					foreach (var person in dictionary.Where(c=> c.Value <= age))
					{
						Console.WriteLine($"{person.Key} - {person.Value}");
					}
				}
				else
				{
					if (format[0] == "name")
					{
						foreach (var person in dictionary.Where(c=> c.Value <= age))
						{
							Console.WriteLine(person.Key);
						}
					}
					else
					{
						foreach (var person in dictionary.Where(c => c.Value <= age))
						{
							Console.WriteLine(person.Value);
						}
					}
				}
			}
			else
			{
				if (format.Length > 1)
				{
					foreach (var person in dictionary.Where(c=> c.Value >= age))
					{
						Console.WriteLine($"{person.Key} - {person.Value}");
					}
				}
				else
				{
					if (format[0] == "name")
					{
						foreach (var person in dictionary.Where(c => c.Value >= age))
						{
							Console.WriteLine(person.Key);
						}
					}
					else
					{
						foreach (var person in dictionary.Where(c => c.Value >= age))
						{
							Console.WriteLine(person.Value);
						}
					}
				}
			}
		}
	}
}
