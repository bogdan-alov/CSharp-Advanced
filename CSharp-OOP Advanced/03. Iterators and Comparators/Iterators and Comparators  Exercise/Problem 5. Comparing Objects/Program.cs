using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Comparing_Objects
{
	class Program
	{
		static void Main()
		{

			var input = "";
			var people = new List<Person>();
			while ((input = Console.ReadLine()) != "END")
			{
				var args = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
				var person = new Person(args[0], int.Parse(args[1]), args[2]);

				people.Add(person);

			}

			var personToWorkWith = people[int.Parse(Console.ReadLine()) - 1];

			var equalPeople = people.Where(c => c.CompareTo(personToWorkWith) == 0).ToList();
			var notEqualPeople = people.Where(c => c.CompareTo(personToWorkWith) == 1).ToList();

			if (equalPeople.Count <= 1) 
			{
				Console.WriteLine("No matches");
			}
			else
			{
				Console.WriteLine($"{equalPeople.Count} {notEqualPeople.Count} {people.Count}");
			}

		}
	}
}
