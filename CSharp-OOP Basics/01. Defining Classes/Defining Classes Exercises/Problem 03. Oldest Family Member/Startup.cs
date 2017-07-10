using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03.Oldest_Family_Member
{
	class Startup
	{
		static void Main(string[] args)
		{
			MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
			MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
			if (oldestMemberMethod == null || addMemberMethod == null)
			{
				throw new Exception();
			}


			var n = int.Parse(Console.ReadLine());
			var family = new Family();
			for (int i = 0; i < n; i++)
			{
				var person = new Person();
				var input = Console.ReadLine().Split(' ');

				person.name = input[0];
				person.age = int.Parse(input[1]);
				family.AddMember(person);

			}

			var oldestMember = family.GetOldestMember();
			Console.WriteLine($"{oldestMember.name} {oldestMember.age}");
		}
	}
}
