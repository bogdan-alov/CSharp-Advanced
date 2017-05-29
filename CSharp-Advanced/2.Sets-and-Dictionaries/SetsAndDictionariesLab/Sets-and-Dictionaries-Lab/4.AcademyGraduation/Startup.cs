using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.AcademyGraduation
{
	class Startup
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var students = new SortedDictionary<string, double[]>();
			for (int i = 0; i < n; i++)
			{
				var student = Console.ReadLine();
				var gradesInput = Console.ReadLine();
				var grades = gradesInput.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
				if (!students.ContainsKey(student))
				{
					students.Add(student, grades );
				}

			}

			foreach (var student in students)
			{
				Console.WriteLine($"{student.Key} is graduated with {student.Value.Sum() / student.Value.Length}");
			}
		}
	}
}
