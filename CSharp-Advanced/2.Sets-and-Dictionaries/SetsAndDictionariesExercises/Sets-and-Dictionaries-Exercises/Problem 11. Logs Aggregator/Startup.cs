using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11.Logs_Aggregator
{
	class Startup
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var dictionary = new SortedDictionary<string, SortedDictionary<string,int>>();
			for (int i = 0; i < n; i++)
			{
				var input = Console.ReadLine();
				var array = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
				var ip = array[0];
				var user = array[1];
				var duration = int.Parse(array[2]);
				var ips = new SortedDictionary<string,int>();
				if (!dictionary.ContainsKey(user))
				{
					ips.Add(ip,duration);
					dictionary.Add(user,ips);
				}
				else
				{
					if (dictionary[user].ContainsKey(ip))
					{
						dictionary[user][ip] += duration;
					}
					else
					{
						dictionary[user].Add(ip, duration);

					}
				}
			}

			foreach (var user in dictionary)
			{
				Console.Write($"{user.Key}: ");
				var sumOfDuration = 0;
				var list = new List<string>();
				foreach (var i in user.Value)
				{
					sumOfDuration += i.Value;
					list.Add(i.Key);
				}
				Console.Write($"{sumOfDuration} [{string.Join(", ", list )}]");
				Console.WriteLine();
			}
		}
	}
}
