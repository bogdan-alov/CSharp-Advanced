using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Take_Two
{
	class Startup
	{
		static void Main(string[] args)
		{
			Console.ReadLine().Split(' ').Select(int.Parse).ToList().Where(c => c >= 10 && c <= 20).Distinct().Take(2)
				.ToList().ForEach(c => Console.Write(c + " "));
		}
	}
}
