using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_04.Opinion_Poll
{
	class Startup
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var list = new List<Person>();
			for (int i = 0; i < n; i++)
			{
				var person = new Person();
				var input = Console.ReadLine().Split(' ');

				person.name = input[0];
				person.age = int.Parse(input[1]);
				list.Add(person);

			}

			var olderMembers = list.Where(c => c.age > 30).OrderBy(c => c.name).ToList();
			foreach (var member in olderMembers)
			{
				Console.WriteLine($"{member.name} - {member.age}");
			}
		}
	}
}
