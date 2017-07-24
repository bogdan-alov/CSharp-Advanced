using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_08.Military_Force.Models.Interfaces;

namespace Problem_08.Military_Force.Models
{
	class PrivateSoldier : Soldier
	{

		public PrivateSoldier(string id, string firstName, string lastName, double salary) : base(id, firstName, lastName, salary)
		{
		}

		public override string ToString()
		{
			return $"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:f2}";
		}
	}
}
