using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Recursive_Fibonacci
{
	class Startup
	{
		public static long[] array;
		public static void Main()
		{
			
			var n = long.Parse(Console.ReadLine());
			array = new long[n];
			array[0] = 1;
			array[1] = 1;
			var result = GetFibonacci(n);
			Console.WriteLine(result);
		}

		public static long GetFibonacci(long n)
		{
			
			if (n <= 2)
			{
				return 1;
			}
			if (array[n - 1] != 0)
			{
				return array[n - 1];
			}
			return array[n - 1] = GetFibonacci(n - 1) + GetFibonacci(n - 2);
		}

	}
}
