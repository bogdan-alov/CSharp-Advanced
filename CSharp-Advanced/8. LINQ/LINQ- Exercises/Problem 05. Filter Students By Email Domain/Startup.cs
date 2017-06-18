using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_05.Filter_Students_By_Email_Domain
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
				student.Email = input[2];
				list.Add(student);

				input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
			}

			foreach (var student in list.Where(c=> c.Email.Contains("@gmail.com")))
			{
				Console.WriteLine($"{student.FirstName} {student.LastName}");
			}
		}
	}

	class Student
	{
		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Email { get; set; }
	}
}
