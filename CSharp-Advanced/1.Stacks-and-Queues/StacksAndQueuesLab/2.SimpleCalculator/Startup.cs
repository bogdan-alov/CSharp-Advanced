using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.SimpleCalculator
{
	class Startup
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			var array = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
			var stack = new Stack<string>(array.Reverse());
			while (stack.Count > 1)
			{
				var firstNumber = int.Parse(stack.Pop());
				var sign = stack.Pop();
				var secondNumber = int.Parse(stack.Pop());
				if (sign == "+")
				{
					stack.Push((firstNumber + secondNumber).ToString());
				}
				if (sign == "-")
				{
					stack.Push((firstNumber - secondNumber).ToString());
				}
			}
			Console.WriteLine(stack.Pop());
		}
				
		}
	}

