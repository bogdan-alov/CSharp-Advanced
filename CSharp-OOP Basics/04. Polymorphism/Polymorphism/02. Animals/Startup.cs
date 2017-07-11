using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Animals
{
	class Startup
	{
		static void Main(string[] args)
		{
			Animal cat = new Cat("Pesho", "Koteshka Hrana");
			Animal dog = new Dog("Gosho", "Meso");

			Console.WriteLine(cat.ExplainMyself());
			Console.WriteLine(dog.ExplainMyself());
		}
	}
}
