using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_06.Strategy_Pattern.Comparators;

namespace Problem_06.Strategy_Pattern
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var sortedByName = new HashSet<Person>();
			var sortedByAge = new SortedSet<Person>();
			for (int i = 0; i < n; i++)
			{
				var input = Console.ReadLine().Split(' ');
				var person = new Person(input[0], int.Parse(input[1]));
				sortedByAge.Add(person);
				sortedByName.Add(person);


			}

			Console.WriteLine(sortedByAge.Count);
			Console.WriteLine(sortedByName.Count);
		}
	}
}
