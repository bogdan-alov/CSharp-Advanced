using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.User_Logs
{
	class Startup
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			var dictionary = new SortedDictionary<string, Dictionary<string, int>>();
			while (input != "end")
			{
				var array = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
				var ip = array[0].Substring(3);
				var message = array[1].Substring(8);
				var user = array[2].Substring(5);
				if (!dictionary.ContainsKey(user))
				{
					dictionary.Add(user, new Dictionary<string, int>());
					dictionary[user].Add(ip,0);
				}
				if (dictionary.ContainsKey(user))
				{
					if (dictionary[user].ContainsKey(ip))
					{
						dictionary[user][ip] += 1;
					}
					else
					{
						dictionary[user].Add(ip,1);
					}
				}
				input = Console.ReadLine();
			}

			foreach (var value in dictionary)
			{
				var counter = 0;
				var elements = value.Value.Count;
				Console.WriteLine($"{value.Key}: ");
				foreach (var element in value.Value)
				{
					
					if (elements == 1)
					{
						Console.WriteLine($"{element.Key} => {element.Value}.");
					}
					else if (counter + 1 == elements )
					{
						Console.WriteLine($"{element.Key} => {element.Value}.");
					}
					else
					{

							Console.Write($"{element.Key} => {element.Value}, ");
					}
					counter++;
				}
			}
		}
	}
}
