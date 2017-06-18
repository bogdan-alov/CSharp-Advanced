using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Concatinate_Strings
{
	class Startup
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var sb = new StringBuilder();
			for (int i = 0; i < n; i++)
			{
				sb.Append(Console.ReadLine()).Append(" ");
			}
			Console.WriteLine(sb);
		}
	}
}
