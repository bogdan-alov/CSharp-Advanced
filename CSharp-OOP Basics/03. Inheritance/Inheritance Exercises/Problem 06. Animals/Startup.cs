using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_06.Animals
{
	class Startup
	{
		static void Main(string[] args)
		{

			var input = "";
			var animals = new List<Animal>();
			while ((input = Console.ReadLine()) != "Beast!")
			{
				try
				{
					var input1 = Console.ReadLine().Split();
					var name = input1[0];
					int age = 0;
					var gender = input1[2];
					if(!int.TryParse(input1[1], out age))
					{
						throw new Exception("Invalid input!");
					}
					if (input == "Cat")
					{
						var cat = new Cat(name, age, gender);
						animals.Add(cat);
					}
					else if (input == "Dog")
					{
						var dog = new Dog(name, age, gender);
						animals.Add(dog);
					}
					else if (input == "Frog")
					{
						var frog = new Frog(name, age, gender);
						animals.Add(frog);
					}
					else if (input == "Kitten")
					{
						var kitten = new Kittens(name, age);
						animals.Add(kitten);
					}
					else if (input == "Tomcat")
					{
						var tomcat = new Tomcat(name, age);
						animals.Add(tomcat);
					}
					else
					{
						throw new Exception("Invalid input!");
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				
				}
			}

			foreach (var animal in animals)
			{
				Console.WriteLine(animal);
			}
		}
	}
}
