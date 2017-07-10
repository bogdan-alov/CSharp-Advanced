using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Ashes_Of_Roses
{
	class Startup
	{
		static void Main(string[] args)
		{
			var pattern = @"^Grow\s<([A-Z][a-z]+)>\s<([A-Za-z0-9]+)>\s(\d+)$";
			var input = Console.ReadLine();
			var dictionary = new Dictionary<string, Dictionary<string, long>>();
			while (input != "Icarus, Ignite!")
			{
				var match = Regex.Match(input, pattern);
				if (match.Success)
				{
					var region = match.Groups[1].Value;
					var color = match.Groups[2].Value;
					var amount = long.Parse(match.Groups[3].Value);

					if (!dictionary.ContainsKey(region))
					{
						dictionary.Add(region, new Dictionary<string, long>());
						dictionary[region].Add(color,amount);
					}
					else 
					{
						if (!dictionary[region].ContainsKey(color))
						{
							dictionary[region].Add(color, amount);
						}
						else
						{
							dictionary[region][color] += amount;
						}
					}
				}


				input = Console.ReadLine();
			}

			foreach (var pair in dictionary.OrderByDescending(c=> c.Value.Values.Sum()).ThenBy(c=> c.Key))
			{
				Console.WriteLine($"{pair.Key}");
				foreach (var i in pair.Value.OrderBy(c=> c.Value).ThenBy(c=> c.Key))
				{
					Console.WriteLine($"*--{i.Key} | {i.Value}");
				}
			}
		}
	}
}
