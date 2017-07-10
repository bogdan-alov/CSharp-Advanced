using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Hierarchical_Inheritance
{
	class Startup
	{
		static void Main(string[] args)
		{
			var dog = new Dog();
			dog.Eat(); 
			dog.Bark();

			var cat = new Cat();
			cat.Eat();
			cat.Meow();

		}
	}
}
