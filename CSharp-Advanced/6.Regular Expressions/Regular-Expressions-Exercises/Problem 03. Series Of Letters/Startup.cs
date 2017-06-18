using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03.Series_Of_Letters
{
	class Startup
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			var sb = new StringBuilder();
			sb.Append(input[0]);

			for (int i = 0; i < input.Length - 1; i++)
			{
				if (input[i] != input[i + 1])
				{
					sb.Append(input[i + 1]);
				}


			}
			Console.WriteLine(sb);
		}
	}
}