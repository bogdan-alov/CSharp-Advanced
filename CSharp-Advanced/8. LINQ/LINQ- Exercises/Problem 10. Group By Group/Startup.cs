using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10.Group_By_Group
{
	class Startup
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
			var list = new List<Student>();
			while (input[0] != "END")
			{
				var student = new Student();
				student.FullName = input[0] + " " + input[1];
				student.Group = int.Parse(input[2]);
				list.Add(student);

				input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
			}
			var results = list.GroupBy(
				p => p.Group,
				p => p.FullName,
				(key, g) => new { Group = key, Students = g.ToList() });
			foreach (var student in results.OrderBy(c=> c.Group))
			{
				Console.WriteLine($"{student.Group} - {string.Join(", ", student.Students)}");
			}
		}
	}

	class Student
	{
		public string FullName { get; set; }

		public int Group { get; set; }
	}
}
