using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _03.First_Name
{
	class Startup
	{
		static void Main(string[] args)
		{
			var names = Console.ReadLine().Split(' ').ToList();
			var letters = Console.ReadLine().Split(' ').OrderBy(c=> c);

			foreach (var letter in letters)
			{
				var result = names.Where(c => c.ToLower().StartsWith(letter.ToLower())).FirstOrDefault();
				if (!string.IsNullOrEmpty(result))
				{
					Console.WriteLine(result);
					break;
				}
				else
				{
					Console.WriteLine("No match");
					break;
				}
			}
		}
	}
}
