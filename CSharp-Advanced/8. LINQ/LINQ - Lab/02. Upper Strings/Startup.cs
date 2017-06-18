using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Upper_Strings
{
	class Startup
	{
		static void Main(string[] args)
		{
			Console.ReadLine().Split(' ').ToList().Select(c=> c.ToUpper()).ToList().ForEach(c=> Console.Write(c + " "));
		}
	}
}
