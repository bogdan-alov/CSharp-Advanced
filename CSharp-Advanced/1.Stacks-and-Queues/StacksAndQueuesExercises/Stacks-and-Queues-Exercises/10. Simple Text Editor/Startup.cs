using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Simple_Text_Editor
{
	class Startup
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());

			var stack = new Stack<string>();
			stack.Push(string.Empty);

			for (int i = 0; i < n; i++)
			{
				var input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
				switch (input[0])
				{

					case "1":

						string conCat = stack.Peek() + input[1];
						stack.Push(conCat);

						break;
					case "2":
						int numToRemove = int.Parse(input[1]);
						string stringToRemove = stack.Peek().Remove(stack.Peek().Length - numToRemove);
						stack.Push(stringToRemove);
						break;
					case "3":
						int indexOfChar = int.Parse(input[1]);
						var element = stack.Peek();
						Console.WriteLine(element[indexOfChar - 1]);
						break;
					case "4":
						stack.Pop();
						break;
				}
			}
		}
	}
}
