using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Periodic_Table
{
	class Startup
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var set = new SortedSet<string>();

			for (int i = 0; i < n; i++)
			{
				var input = Console.ReadLine();
				var array = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
				foreach (var ele in array)
				{
					set.Add(ele);
				}
				
			}
			foreach (var element in set)
			{
				Console.Write($"{element} ");
			}
		}
	}
}
