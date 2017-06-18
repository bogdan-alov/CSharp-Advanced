using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Convert_base_10_to_base_N
{
	class Startup
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();
			var first = input[0];
			var second = input[1];
			var list = new List<BigInteger>();
			while (second > 0)
			{
				BigInteger remainer = second % first;
				second /= first;
				list.Add(remainer);
			}
			for (int i = list.Count - 1; i >= 0; i--)
			{
				Console.Write(list[i]);
			}
			Console.WriteLine();
		}
	}
}
