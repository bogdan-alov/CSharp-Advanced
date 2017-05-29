using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Sets_of_Elements
{
	class Startup
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			var array = input.Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
			var n = int.Parse(array[0]);
			var m = int.Parse(array[1]);
			var firstSet = new HashSet<int>();
			//var secondSet = new HashSet<int>();
			var hashtable = new Hashtable();
			for (int i = 0; i < n; i++)
			{
				var input2 = int.Parse(Console.ReadLine());
				firstSet.Add(input2);
			}

			for (int i = 0; i < m; i++)
			{
				var input2 = int.Parse(Console.ReadLine());
				hashtable.Add(i,input2);
			}

			foreach (var element in firstSet)
			{
				if (hashtable.ContainsValue(element))
				{
					Console.Write($"{element} ");
				}
			}
			
		}
	}
}
