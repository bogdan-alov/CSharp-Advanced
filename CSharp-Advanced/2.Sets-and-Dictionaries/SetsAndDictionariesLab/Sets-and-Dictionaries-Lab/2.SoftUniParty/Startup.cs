using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.SoftUniParty
{
	class Startup
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			var vips = new SortedSet<string>();
			var regular = new SortedSet<string>();
			while (input != "PARTY")
			{
				int number;
				bool IsDigit = int.TryParse(input[0].ToString(), out number);
				if (IsDigit)
				{
					vips.Add(input);
				}
				else
				{
					regular.Add(input);
				}

				input = Console.ReadLine();
			}

			var input2 = Console.ReadLine();
			while (input2 != "END")
			{
				if (vips.Contains(input2))
				{
					vips.Remove(input2);
				}
				if (regular.Contains(input2))
				{
					regular.Remove(input2);
				}
				input2 = Console.ReadLine();
			}

			vips.UnionWith(regular);
			Console.WriteLine(vips.Count);
			foreach (var person in vips)
			{
				Console.WriteLine(person);
			}
		}
	}
}
