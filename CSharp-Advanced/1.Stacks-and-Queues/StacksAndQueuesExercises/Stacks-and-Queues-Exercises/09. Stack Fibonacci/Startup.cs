using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Stack_Fibonacci
{
	class Startup
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var stack = new Stack<int>();
			stack.Push(0);
			stack.Push(1);
			for (int i = 2; i < n; i++)
			{
				stack.Push(stack.Pop() + stack.Peek());
			}
			if (n == 1 || n == 2)
			{
				Console.WriteLine(1);
			}
			if (n == 0)
			{
				Console.WriteLine(0);
			}
			Console.WriteLine(stack.Pop());
		}



	}
}
