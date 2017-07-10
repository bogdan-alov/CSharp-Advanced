using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12.Google
{
	class Startup
	{
		static void Main(string[] args)
		{
			var input = "";
			var list =new List<Person>();
			while ((input = Console.ReadLine()) != "End")
			{
				
				var array = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
				var command = array[1];
				if (!list.Any(c=> c.Name == array[0]))
				{
					list.Add(new Person(array[0]));
				}

				var person = list.FirstOrDefault(p => p.Name == array[0]);

				if (command == "company")
				{
					var company = new Company();
					company.Name = array[2];
					company.Position = array[3];
					company.Salary = decimal.Parse(array[4]);
					person.Company = company;
				}
				else if (command == "car")
				{
					var car = new Car();
					car.Name = array[2];
					car.Power = int.Parse(array[3]);
					person.Car = car;
				}
				else if (command == "pokemon")
				{
					var pokemon = new Pokemon();
					pokemon.Name = array[2];
					pokemon.Element = array[3];
					person.Pokemons.Add(pokemon);
				}
				else if (command == "parents")
				{
					var parent = new Parent();
					parent.Name = array[2];
					parent.BirthDate = array[3];
					person.Parents.Add(parent);
				}
				else if (command == "children")
				{
					var child = new Child();
					child.Name = array[2];
					child.BirthDate = array[3];
					person.Children.Add(child);
				}
			
			}
			input = Console.ReadLine();
			var person2 = list.FirstOrDefault(c=> c.Name == input);
			Console.WriteLine(person2.Name);
			if (person2.Company.Salary == null)
			{
				Console.WriteLine("Company:");
			}
			else
			{
				Console.WriteLine($"Company:\n{person2.Company.Name} {person2.Company.Position} {person2.Company.Salary:f2}");
			}
			Console.WriteLine($"Car:\n{person2.Car.Name} {person2.Car.Power}");
			Console.WriteLine("Pokemon:");
			foreach (var person2Pokemon in person2.Pokemons)
			{
				Console.WriteLine($"{person2Pokemon.Name} {person2Pokemon.Element}");
			}
			Console.WriteLine("Parents:");
			foreach (var person2Parent in person2.Parents)
			{
				Console.WriteLine($"{person2Parent.Name} {person2Parent.BirthDate}");
			}
			Console.WriteLine("Children:");
			foreach (var person2Child in person2.Children)
			{
				Console.WriteLine($"{person2Child.Name} {person2Child.BirthDate}");
			}
		}
	}
}
