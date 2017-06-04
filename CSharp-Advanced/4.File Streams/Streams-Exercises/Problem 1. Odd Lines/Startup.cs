using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Odd_Lines
{
	class Startup
	{
		static void Main(string[] args)
		{
			using (StreamReader reader = new StreamReader(@"../../textFile.txt"))
			{
				int counter = 1;
				string line = reader.ReadLine();
				while (line != null)
				{
					if (counter % 2 != 0)
					{
						Console.WriteLine(line);
					}
					counter++;
					line = reader.ReadLine();
				}
			}
		}
	}
}
