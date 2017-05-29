using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Maximum_Element
{
	class Startup
	{

		static void Main()
		{
			var n = int.Parse(Console.ReadLine());
			var stack = new Stack<int>();
			var maxValue = int.MinValue;
			var maxStack = new Stack<int>();
			while (n != 0)
			{

				var numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
				if (numbers[0] == 1)
				{
					stack.Push(numbers[1]);
					if (maxValue < numbers[1])
					{
						maxValue = numbers[1];
						maxStack.Push(maxValue);
					}
				}
				else if (numbers[0] == 2)
				{
					if (stack.Pop() == maxValue)
					{
						maxStack.Pop();
						if (maxStack.Count != 0)
						{
							maxValue = maxStack.Peek();
						}
					}
				}

				else if (numbers[0] == 3 && stack.Count != 0)
				{
					Console.WriteLine(maxValue);
				}
				n--;
			}
		}
	}

}

