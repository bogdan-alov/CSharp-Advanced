using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CountSameValuesInArray
{
	class Startup
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			var numbers = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
			var dict = new SortedDictionary<double, int>();
			for (int i = 0; i < numbers.Length; i++)
			{
				double number = numbers[i];
				if (!dict.ContainsKey(number))
				{
					dict.Add(numbers[i], 1);
				}
				else
				{
					dict[numbers[i]]++;
				}
			}
			foreach (var number in dict)
			{
				Console.WriteLine($"{number.Key} - {number.Value} times");
			}
		}
	}
}
