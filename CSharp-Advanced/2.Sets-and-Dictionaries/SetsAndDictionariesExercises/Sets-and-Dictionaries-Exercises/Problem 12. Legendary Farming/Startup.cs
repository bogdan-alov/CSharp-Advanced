using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12.Legendary_Farming
{
	class Startup
	{
		static void Main(string[] args)
		{
			var materials = new Dictionary<string,int>()
			{
				{"motes", 0},
				{"shards", 0},
				{"fragments", 0}
			};
			var junkies = new Dictionary<string,int>(){};
			var IsDone = false;
			for (int i = 0; i < 10; i++)
			{
				var quantity = 0;
				var material = "";

				var input = Console.ReadLine().Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
				for (int j = 0; j < input.Length; j++)
				{
					
					if (j % 2 == 0 )
					{
						quantity = int.Parse(input[j]);
					}
					else
					{
						material = input[j].ToLower();
					}

					if (material != "" && materials.ContainsKey(material))
					{
						materials[material] += quantity;

						if (materials[material] >= 250 && material == "motes")
						{
							Console.WriteLine($"Dragonwrath obtained!");
							materials["motes"] -= 250;
							foreach (var material1 in materials.OrderByDescending(c => c.Value).ThenBy(c => c.Key))
							{
								Console.WriteLine($"{material1.Key}: {material1.Value}");
							}
							IsDone = true;
							break;
						}
						if (materials[material] >= 250 && material == "shards")
						{
							Console.WriteLine($"Shadowmourne obtained!");
							materials["shards"] -= 250;
							foreach (var material1 in materials.OrderByDescending(c => c.Value).ThenBy(c => c.Key))
							{
								Console.WriteLine($"{material1.Key}: {material1.Value}");
							}
							IsDone = true;
							break;
						}
						if (materials[material] >= 250 && material == "fragments")
						{
							Console.WriteLine($"Valanyr obtained!");
							materials["fragments"] -= 250;
							foreach (var material1 in materials.OrderByDescending(c => c.Value).ThenBy(c => c.Key))
							{
								Console.WriteLine($"{material1.Key}: {material1.Value}");
							}
							IsDone = true;
							break;
						}
					}
					if (material != "" && junkies.ContainsKey(material))
					{
						junkies[material] += quantity;
					}

					if (material != "" && !materials.ContainsKey(material) && !junkies.ContainsKey(material))
					{
						junkies.Add(material,quantity);
					}
					material = "";
				}
				if (IsDone)
				{
					break;
				}
			}
			foreach (var junky in junkies.OrderBy(c=> c.Key))
			{
				Console.WriteLine($"{junky.Key}: {junky.Value}");

			}
		}
	}
}
