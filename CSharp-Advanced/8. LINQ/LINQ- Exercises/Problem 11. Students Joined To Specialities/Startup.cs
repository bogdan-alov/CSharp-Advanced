using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11.Students_Joined_To_Specialities
{
	class Startup
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
			var specialities = new List<Speciality>();
			var students = new List<Student>();
			while (input[0] != "Students:")
			{
				var speciality = new Speciality();
				speciality.SpecialityName = input[0] + " " + input[1];
				speciality.FacNumber = int.Parse(input[2]);
				specialities.Add(speciality);

				input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			}
			input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			while (input[0] != "END")
			{
				var student = new Student();
				student.Name = input[1] + " " + input[2];
				student.FacNumber = int.Parse(input[0]);

				students.Add(student);
				input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			}
			var results = specialities.Join(students, c => c.FacNumber, x => x.FacNumber,
				(c, x) => new {Name = x.Name, Speciality = c.SpecialityName, FacNumber = c.FacNumber}).OrderBy(c=> c.Name).ToList();

			foreach (var result in results)
			{
				Console.WriteLine($"{result.Name} {result.FacNumber} {result.Speciality}");
			}
		}
	}

	class Speciality
	{
		public string SpecialityName { get; set; }

		public int FacNumber { get; set; }
	}

	class Student
	{
		public int FacNumber { get; set; }
		public string Name { get; set; }
	}
}
