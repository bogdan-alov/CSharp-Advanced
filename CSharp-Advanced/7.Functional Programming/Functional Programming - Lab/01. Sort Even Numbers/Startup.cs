using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sort_Even_Numbers
{
	class Startup
	{
		static void Main(string[] args)
		{
			Console.WriteLine(string.Join(", ", Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Where(c => c % 2 == 0).OrderBy(c => c)));
		}
	}
}
