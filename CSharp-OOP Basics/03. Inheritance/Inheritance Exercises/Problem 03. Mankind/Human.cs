using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03.Mankind
{
	class Human
	{
		public Human(string firstName, string lastName)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
		}
		private string firstName;

		public string FirstName
		{
			get { return firstName; }
			protected set
			{
				if (!char.IsUpper(value[0]))
				{
					throw new ArgumentException("Expected upper case letter! Argument: firstName");
				}
				if (value.Length < 4)
				{
					throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
				}
				firstName = value;
			}
		}


		private string lastName;

		public string LastName
		{
			get { return lastName; }
			protected set
			{
				if (!char.IsUpper(value[0]))
				{
					throw new ArgumentException("Expected upper case letter! Argument: lastName");
				}
				if (value.Length <= 2)
				{
					throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
				}
				lastName = value;
			}
		}
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.AppendLine($"First Name: {this.FirstName}")
				.AppendLine($"Last Name: {this.LastName}");

			return sb.ToString();
		}
	}
}
