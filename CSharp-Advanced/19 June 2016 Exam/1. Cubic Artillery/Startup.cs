using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1.Cubic_Artillery
{
	class Startup
	{
		static void Main(string[] args)
		{
			var capacity = int.Parse(Console.ReadLine());
			var input = Console.ReadLine();
			var bunkerWeapons = new Dictionary<string, Queue<int>>();
			var bunkersLoad = new Dictionary<string, int>();
			while (input != "Bunker Revision")
			{

				var array = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();


				foreach (var s in array)
				{
					var weapon = 0;
					var isDigit = int.TryParse(s, out weapon);
					if (!isDigit)
					{
						var bunker = s;
						bunkerWeapons.Add(bunker, new Queue<int>());
						bunkersLoad.Add(bunker, 0);
					}
					else
					{
						foreach (var bunker in bunkerWeapons)
						{
							var keysToRemove = new HashSet<string>();
							if (bunkersLoad[bunker.Key] + weapon > capacity && bunkerWeapons.Count > 1)
							{
								if (bunkerWeapons[bunker.Key].Count > 0)
								{
									Console.WriteLine($"{bunker.Key} -> {string.Join(", ", bunkerWeapons[bunker.Key])}");
								}
								else
								{
									Console.WriteLine($"{bunker.Key} -> Empty");

								}
								keysToRemove.Add(bunker.Key);
								continue;
							}
							else
							{


							}
							if (weapon > capacity)
							{

								break;

							}

							bunkerWeapons[bunker.Key].Enqueue(weapon);
							bunkersLoad[bunker.Key] += weapon;

						}


					}

				}


				input = Console.ReadLine();
			}

		}


	}
}
