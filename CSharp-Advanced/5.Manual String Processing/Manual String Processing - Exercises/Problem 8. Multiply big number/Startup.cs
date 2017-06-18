using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Multiply_big_number
{
	class Startup
	{
		static void Main(string[] args)
		{
			string numberAsString = Console.ReadLine();
			string numberAsString2 = Console.ReadLine();
			var number = BigInteger.Parse(numberAsString);
			var number2 = BigInteger.Parse(numberAsString2);
			var total = number * number2;
			Console.WriteLine(total);
		}
	}
}
