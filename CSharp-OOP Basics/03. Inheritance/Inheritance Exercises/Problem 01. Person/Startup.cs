using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_01.Person.Models;

namespace Problem_01.Person
{
	class Startup
	{
		static void Main(string[] args)
		{
			string name = Console.ReadLine();
			int age = int.Parse(Console.ReadLine());

			try
			{
				Child child = new Child(name, age);
				Console.WriteLine(child);
			}
			catch (Exception ae)
			{
				Console.WriteLine(ae.Message);
			}

		}
	}
}
