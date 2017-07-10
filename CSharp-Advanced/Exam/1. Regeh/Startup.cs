using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1.Regeh
{
	class Startup
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();

			var pattern = "[[][^ []+?<(\\d+)REGEH(\\d+)>[^ ]+?]";

			var matches = Regex.Matches(input, pattern);
			var indexes = new Stack<long>();
			var counter = 0;
			foreach (Match match in matches)
			{

				if (counter == 0)
				{
					var index1 = long.Parse(match.Groups[1].Value);
					indexes.Push(index1);
					var index2 = long.Parse(match.Groups[2].Value) + indexes.Peek();
					indexes.Push(index2);
				}
				else
				{
					var index1 = long.Parse(match.Groups[1].Value) + indexes.Peek();
					indexes.Push(index1);
					var index2 = long.Parse(match.Groups[2].Value) + indexes.Peek();
					indexes.Push(index2);
				}
				counter++;
			}
			var array = indexes.Reverse().ToArray();
			var sb = new StringBuilder();

			foreach (var number in array)
			{
				if (number > input.Length)
				{
					var index = number - input.Length + 1;
					sb.Append(input[(int)index]);
				}
				else if (number == input.Length)
				{
					var index = 0;
					sb.Append(input[index]);
				}
				else
				{
					sb.Append(input[(int)number]);
				}

			}
			Console.WriteLine(sb);
		}
	}
}
