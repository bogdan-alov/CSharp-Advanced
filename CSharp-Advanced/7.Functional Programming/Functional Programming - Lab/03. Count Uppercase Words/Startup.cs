using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Count_Uppercase_Words
{
	class Startup
	{
		static void Main(string[] args)
		{
			Console.WriteLine(string.Join("\n", Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Where(c => Char.IsUpper(c[0])).ToArray()));
		}
	}
}
