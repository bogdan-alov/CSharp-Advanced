using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01.Students_by_Group
{
	class Startup
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
			var list = new List<Student>();
			while (input[0] != "END" )
			{
				var student = new Student();
				student.FirstName = input[0];
				student.LastName = input[1];
				student.Group = int.Parse(input[2]);
				list.Add(student);

				input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
			}

			foreach (var student in list.Where(c=> c.Group == 2).OrderBy(c=> c.FirstName))
			{
				Console.WriteLine($"{student.FirstName} {student.LastName}");
			}
		}
	}

	class Student
	{
		public string FirstName { get; set; }

		public string LastName { get; set; }

		public int Group { get; set; }
	}
}
