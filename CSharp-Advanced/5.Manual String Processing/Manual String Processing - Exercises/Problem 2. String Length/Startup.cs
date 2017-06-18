using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.String_Length
{
	class Startup
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();

			var outPut = input.PadRight(20, '*');
			Console.WriteLine(outPut);
		}
	}
}
