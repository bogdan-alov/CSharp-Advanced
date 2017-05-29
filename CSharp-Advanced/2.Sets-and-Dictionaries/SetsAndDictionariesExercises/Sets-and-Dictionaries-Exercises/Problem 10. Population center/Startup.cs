using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10.Population_center
{
	class Startup
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine().Split('|').ToArray();
			Dictionary<string, Dictionary<string, long>> data = new Dictionary<string, Dictionary<string, long>>();

			while (input[0] != "report")
			{
				string city = input[0];
				string country = input[1];
				long population = long.Parse(input[2]);

				if (!data.ContainsKey(country))
				{
					data.Add(country, new Dictionary<string, long>());
				}
				if (!data[country].ContainsKey(city))
				{
					data[country].Add(city, population);
				}
				else
				{
					data[country][city] += population;
				}
				input = Console.ReadLine().Split('|').ToArray();
			}
			var orderedCountry = data.OrderByDescending(x => x.Value.Values.Sum());
			foreach (var item in orderedCountry)
			{
				Console.WriteLine("{0} (total population: {1})", item.Key, item.Value.Values.Sum());
				foreach (var values in item.Value.OrderByDescending(x => x.Value))
				{
					Console.WriteLine($"=>{values.Key}: {values.Value}");
				}
			}
		}
	}
}
