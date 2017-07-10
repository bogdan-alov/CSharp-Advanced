using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12.Google
{
	class Person
	{
		public Person(string name)
		{
			this.Name = name;
			this.Children = new List<Child>();
			this.Pokemons = new List<Pokemon>();
			this.Parents = new List<Parent>();
			this.Company = new Company();
			this.Car = new Car();
		}

		public string Name { get; set; }

		public Car Car { get; set; }

		public Company Company { get; set; }

		public List<Pokemon> Pokemons { get; set; }

		public List<Parent> Parents { get; set; }

		public List<Child> Children { get; set; }

		
	}
}
