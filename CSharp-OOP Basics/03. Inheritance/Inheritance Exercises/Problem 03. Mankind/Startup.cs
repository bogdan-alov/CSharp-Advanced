using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03.Mankind
{
	class Startup
	{
		static void Main(string[] args)
		{
			try
			{
				var input1 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

				var student = new Student(input1[0], input1[1], input1[2]);

				var input2 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
				
				var worker = new Worker(input2[0], input2[1], decimal.Parse(input2[2]), decimal.Parse(input2[3]));

				Console.WriteLine(student);
				Console.WriteLine(worker);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);

			}
		}
	}
}
