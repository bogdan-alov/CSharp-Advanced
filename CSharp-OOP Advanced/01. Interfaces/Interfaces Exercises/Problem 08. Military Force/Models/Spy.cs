using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Problem_08.Military_Force.Models.Interfaces;

namespace Problem_08.Military_Force.Models
{
	class Spy : Soldier, ISpy
	{

		public Spy(string id, string firstName, string lastName, double salary) : base(id, firstName, lastName, salary)
		{
		}

		public int CodeNumber { get; }

		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.AppendLine($"Name {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:f2}");
			sb.AppendLine($"Code Number: {this.CodeNumber}");
			return sb.ToString();
		}
	}
}
