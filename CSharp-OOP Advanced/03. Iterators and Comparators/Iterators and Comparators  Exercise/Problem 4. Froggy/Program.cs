using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Froggy
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine().Split(new char[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
			var lake = new Lake(input);

			Console.WriteLine(string.Join(", ", lake));
		}
	}
}
