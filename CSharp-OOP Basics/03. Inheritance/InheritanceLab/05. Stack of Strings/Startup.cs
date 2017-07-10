using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Stack_of_Strings
{
	class Startup
	{
		static void Main(string[] args)
		{
			var stack = new StackOfStrings();

			

			stack.Push("Pesho");

			stack.Push("Sasho");

			stack.Push("Anton");

			stack.Pop();

			Console.WriteLine(stack.Count);
		}
	}
}
