using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03.Mankind
{
	class Student : Human
	{
		private string facultyNumber;

		public Student(string firstName, string lastName, string facultyNubmer)
			:base(firstName,lastName)
		{
			this.FacultyNumber = facultyNubmer;
		}
		public string FacultyNumber
		{
			get { return facultyNumber; }
			set
			{
				if (value.Length < 5 || value.Length > 10 || !value.All(char.IsLetterOrDigit))
				{
					throw new ArgumentException("Invalid faculty number!");
				}
				facultyNumber = value;
			}
		}

		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append(base.ToString())
				.AppendLine($"Faculty number: {this.FacultyNumber}");

			return sb.ToString();
		}
	}
}
