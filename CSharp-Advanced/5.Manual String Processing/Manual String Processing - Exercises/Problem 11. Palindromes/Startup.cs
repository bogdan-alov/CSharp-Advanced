using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_11.Palindromes
{
	class Startup
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine().Split(new char[] {' ', '.', '!', '-', '?', ','}, StringSplitOptions.RemoveEmptyEntries);
			
			
			var set = new SortedSet<string>();
			foreach (var substring in input)
			{
				if (CheckIfItIsApalindrome(substring))
				{
					set.Add(substring);
				}
			}
			Console.Write("[");
			var counter = 1;
			foreach (var palindrome in set)
			{
				if (counter == set.Count)
				{
					Console.Write($"{palindrome}");
				}
				else
				{
					Console.Write($"{palindrome}, ");
				}
				counter++;
			}
			Console.Write("]");
		}

		public static bool CheckIfItIsApalindrome(string myString)
		{
			string first = myString.Substring(0, myString.Length / 2);
			char[] arr = myString.ToCharArray();
			Array.Reverse(arr);
			string temp = new string(arr);
			string second = temp.Substring(0, temp.Length / 2);
			return first.Equals(second);
		}

	}
}
