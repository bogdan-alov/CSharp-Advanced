using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_08.Military_Force.Models.Interfaces;

namespace Problem_08.Military_Force.Models
{
	public abstract class Soldier : ISoldier, IPrivate, IComparable<Soldier>
	{
		public Soldier(string id, string firstName, string lastName, double salary)
		{
			this.Id = id;
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Salary = salary;

		}
		public string Id { get; }
		public string FirstName { get; }
		public string LastName { get; }
		public double Salary { get; }

		public int CompareTo(Soldier other)
		{
			if (ReferenceEquals(this, other)) return 0;
			if (ReferenceEquals(null, other)) return 1;
			var idComparison = string.Compare(Id, other.Id, StringComparison.Ordinal);
			if (idComparison != 0) return idComparison;
			var firstNameComparison = string.Compare(FirstName, other.FirstName, StringComparison.Ordinal);
			if (firstNameComparison != 0) return firstNameComparison;
			var lastNameComparison = string.Compare(LastName, other.LastName, StringComparison.Ordinal);
			if (lastNameComparison != 0) return lastNameComparison;
			return Salary.CompareTo(other.Salary);
		}
	}
}
