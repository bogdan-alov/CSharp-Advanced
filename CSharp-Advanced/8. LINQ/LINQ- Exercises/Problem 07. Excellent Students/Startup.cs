using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_07.Excellent_Students
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
				student.FirstName = input[0];
				student.LastName = input[1];
				for (int i = 2; i < input.Length; i++)
				{
					var mark = int.Parse(input[i]);
					student.Marks.Add(mark);
				}
				list.Add(student);

				input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
			}

			foreach (var student in list.Where(c=> c.Marks.Any(x=> x == 6)))
			{
				Console.WriteLine($"{student.FirstName} {student.LastName}");
			}
		}
	}

	class Student
	{
		public Student()
		{
			this.Marks = new List<int>();
		}
		public string FirstName { get; set; }

		public string LastName { get; set; }

		public List<int> Marks { get; set; }
	}
}
