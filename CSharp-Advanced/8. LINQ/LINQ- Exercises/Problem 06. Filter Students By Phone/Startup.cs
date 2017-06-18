using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_06.Filter_Students_By_Phone
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
				student.Phone = input[2];
				list.Add(student);

				input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
			}

			foreach (var student in list.Where(c => c.Phone.StartsWith("02") || c.Phone.StartsWith("+3592")))
			{
				Console.WriteLine($"{student.FirstName} {student.LastName}");
			}
		}
	}

	class Student
	{
		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Phone { get; set; }
	}
}
