using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Cubic_Assault
{
	class Startup
	{
		private static long million = 1_000_000;
		static void Main(string[] args)
		{
			var input = Console.ReadLine();

			var meteors = new Dictionary<string, Dictionary<string, long>>();
			while (input != "Count em all")
			{

				var array = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
				var regionName = array[0];
				var color = array[1];
				if (!meteors.ContainsKey(regionName))
				{
					meteors.Add(regionName, new Dictionary<string, long>());
					meteors[regionName].Add("Green", 0);
					meteors[regionName].Add("Red", 0);
					meteors[regionName].Add("Black", 0);
					if (color == "Green")
					{
						var count = int.Parse(array[2]);
						meteors[regionName]["Green"] += count;
					}
					else if (color == "Red")
					{
						var count = int.Parse(array[2]);
						meteors[regionName]["Red"] += count;
						
					}
					else if (color == "Black")
					{
						var count = long.Parse(array[2]);
						meteors[regionName]["Black"] += count; ;
					}
					
				}
				else
				{
					if (color == "Green")
					{
						var count = long.Parse(array[2]);
						meteors[regionName]["Green"] += count;
					}
					else if (array[1] == "Red")
					{
						var count = int.Parse(array[2]);
						meteors[regionName]["Red"] += count;
					}
					else if (color == "Black")
					{
						var count = int.Parse(array[2]);
						meteors[regionName]["Black"] += count; ;
					}
				}
				if (meteors[regionName]["Green"] >= million)
				{
					var redToAdd = meteors[regionName]["Green"] / million;
					meteors[regionName]["Red"] += redToAdd;
					meteors[regionName]["Green"] -= redToAdd * million;
				}
				if (meteors[regionName]["Red"] >= million)
				{
					var blackToAdd = meteors[regionName]["Red"] / million;
					meteors[regionName]["Black"] += blackToAdd;
					meteors[regionName]["Red"] -= blackToAdd * million;
				}


				input = Console.ReadLine();
			}
			var dictionary = meteors.OrderByDescending(c => c.Value.FirstOrDefault(x=> x.Key == "Black").Value).ThenBy(c => c.Key.Length).ThenBy(c => c.Key);
			foreach (var meteor in dictionary)
			{
				Console.WriteLine($"{meteor.Key}");

				foreach (var meteorMeteor in meteor.Value.OrderByDescending(c=> c.Value).ThenBy(c=> c.Key))
				{
					Console.WriteLine($"-> {meteorMeteor.Key} : {meteorMeteor.Value}");
				}
			}
		}
	}

}
