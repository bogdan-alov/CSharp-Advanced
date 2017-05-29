using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Reverse_Numbers
{
	class Startup
	{
		static void Main()
		{
			var readNumbers = Console.ReadLine();
			int[] arrayNumbers = readNumbers.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
			var stack = new Stack<int>(arrayNumbers);

			while (stack.Count != 0)
			{
				if (stack.Count != 0)
				{
					Console.Write($"{stack.Pop()} ");
				}
				else
				{
					Console.Write(stack.Pop());
				}

			}
		}
}
