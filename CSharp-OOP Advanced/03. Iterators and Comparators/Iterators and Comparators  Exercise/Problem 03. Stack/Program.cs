using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03.Stack
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = "";
			var stack = new Stack<string>();
			var list = new List<string>();
			while ((input = Console.ReadLine()) != "END")
			{
				var cmdArgs = input.Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);

				if (cmdArgs[0] == "Push")
				{
					var dataToBeAdded = cmdArgs.Skip(1).ToArray();

					stack.Push(dataToBeAdded);
				}
				else
				{
					stack.Pop();
				}

			}

			for (int i = 0; i < 2; i++)
			{
				foreach (var item in stack)
				{
					Console.WriteLine(item);
				}
			}
		}
	}
}
