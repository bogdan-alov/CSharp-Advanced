using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DecimalToBinaryConverter
{
	class Startup
	{
		static void Main(string[] args)
		{
			var number = int.Parse(Console.ReadLine());
			var stack = new Stack<int>();
			if (number == 0)
			{
				stack.Push(number);
				Console.WriteLine(stack.Pop());
			}
			else
			{
				while (number > 0)
				{
					var newNumber = number % 2;
					number /= 2;
					stack.Push(newNumber);

				}
				var counter = stack.Count();
				for (int i = 0; i < counter; i++)
				{
					Console.Write(stack.Pop());
				}
			}
			
		}
	}
}
