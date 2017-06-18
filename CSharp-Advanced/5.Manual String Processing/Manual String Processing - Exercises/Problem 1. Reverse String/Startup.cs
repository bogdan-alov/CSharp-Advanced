using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Reverse_String
{
	class Startup
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			var sb =new StringBuilder();
			for (int i = input.Length - 1; i >= 0; i--)
			{
				sb.Append(input[i]);
			}
			Console.WriteLine(sb);
		}
	}
}
