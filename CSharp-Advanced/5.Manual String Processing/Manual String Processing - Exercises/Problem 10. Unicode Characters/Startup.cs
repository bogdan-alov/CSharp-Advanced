using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10.Unicode_Characters
{
	class Startup
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			foreach (var item in input)
			{
				Console.Write("\\u{0:x4}", Convert.ToUInt16(item));
			}
		}
	}
}
