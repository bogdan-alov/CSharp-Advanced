using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Line_Numbers
{
	class Startup
	{
		static void Main(string[] args)
		{
			using (StreamReader reader = new StreamReader(@"../../hello.txt"))
			{
				using (StreamWriter writer = new StreamWriter(@"../../hello2.txt"))
				{
					string line = reader.ReadLine();
					var counter = 1;
					while (line != null)
					{
						

						writer.WriteLine($"{counter} {line}");
						counter++;
						line = reader.ReadLine();
					}
				}
			}
		}
	}
}
