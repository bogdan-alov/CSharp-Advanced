using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Unique_Usernames
{
	class Startup
	{
		static void Main(string[] args)
		{
			var number = int.Parse(Console.ReadLine());

			var usernames = new SortedSet<string>();
			var list = new List<string>();
			for (int i = 0; i < number; i++)
			{
				var input = Console.ReadLine();

				if (usernames.Add(input))
				{
					list.Add(input);
				}
			}
			foreach (var person in list)
			{
				Console.WriteLine(person);
			}
		}
	}
}
