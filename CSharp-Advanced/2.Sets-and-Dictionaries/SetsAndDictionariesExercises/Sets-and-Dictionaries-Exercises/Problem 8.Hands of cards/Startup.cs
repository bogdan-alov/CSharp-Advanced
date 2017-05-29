using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Hands_of_cards
{
	class Startup
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			var dictionary = new Dictionary<string, HashSet<string>>();
			var types = new Dictionary<string, int>()
			{
				{"S", 4},
				{"H", 3},
				{"D", 2},
				{"C", 1}
			};
			var values = new Dictionary<string, int>()
			{
				{"2", 2},
				{"3", 3},
				{"4", 4},
				{"5", 5},
				{"6", 6},
				{"7", 7},
				{"8", 8},
				{"9", 9},
				{"10", 10},
				{"J", 11},
				{"Q", 12},
				{"K", 13},
				{"A", 14},
			};


			while (input != "JOKER")
			{
				var array = input.Split(new[] {' ', ',', ';', ':'}, StringSplitOptions.RemoveEmptyEntries).ToArray();
				var cards = new HashSet<string>();
				if (!dictionary.ContainsKey(array[0]))
				{
					
					for (int i = 1; i < array.Length; i++)
					{
						cards.Add(array[i]);
					}
					dictionary.Add(array[0], cards);
				}
				else
				{
					for (int i = 1; i < array.Length; i++)
					{
						dictionary[array[0]].Add(array[i]);
					}
					
				}
				input = Console.ReadLine();
			}
			foreach (var person in dictionary)
			{
				long sumOfCards = 0;
				foreach (var card in person.Value)
				{
					string power = "";
					string type = "";
					if (card.Length > 2)
					{
						power = card[0].ToString() + card[1].ToString();
						type = card[2].ToString();
					}
					else
					{
						power = card[0].ToString();
						type = card[1].ToString();
					}
					if (values.ContainsKey(power) && types.ContainsKey(type))
					{
						
						var calculate = values[power] * types[type];
						sumOfCards += calculate;
					}

				}
				Console.WriteLine($"{person.Key}: {sumOfCards}");
				
			}
		}
	}
}
