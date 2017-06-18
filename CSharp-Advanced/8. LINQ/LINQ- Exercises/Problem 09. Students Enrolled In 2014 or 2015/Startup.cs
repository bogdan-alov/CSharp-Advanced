using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_09.Students_Enrolled_In_2014_or_2015
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
				student.Date = input[0];
				for (int i = 1; i < input.Length; i++)
				{
					var mark = int.Parse(input[i]);
					student.Marks.Add(mark);
				}
				list.Add(student);

				input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
			}

			foreach (var student in list.Where(c => c.Date.EndsWith("15") || c.Date.EndsWith("14")))
			{
				Console.WriteLine(string.Join(" ", student.Marks));
			}
		}
	}

	class Student
	{
		public Student()
		{
			this.Marks = new List<int>();
		}
		public string Date { get; set; }

		public List<int> Marks { get; set; }
	}
}
