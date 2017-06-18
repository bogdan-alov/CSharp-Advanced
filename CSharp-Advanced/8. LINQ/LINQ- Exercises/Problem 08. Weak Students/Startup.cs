using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_08.Weak_Students
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
					if (mark == 2 || mark == 3)
					{
						student.Counter++;
					}
				}
				list.Add(student);

				input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
			}

			foreach (var student in list.Where(c => c.Counter >= 2))
			{
				Console.WriteLine($"{student.FirstName} {student.LastName}");
			}
		}
	}

	class Student
	{
		public Student()
		{
			
		}
		public string FirstName { get; set; }

		public string LastName { get; set; }

		public int Counter { get; set; }
	}
}
