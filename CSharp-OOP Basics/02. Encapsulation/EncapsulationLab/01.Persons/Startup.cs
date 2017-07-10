using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Persons
{
	class Startup
	{
		static void Main(string[] args)
		{
			var person = new Person("Pesho", "Peshev", 20, 2200);
			var person2 = new Person("Pesho", "Peshev", 45, 2200);
			var team = new Team("Barcelona");
			team.AddPlayer(person);
			team.AddPlayer(person2);
			
			Console.WriteLine(team);
		}
	}
}
