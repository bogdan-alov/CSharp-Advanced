using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_08.Military_Force.Models.Interfaces;

namespace Problem_08.Military_Force.Models
{
	class LeutenantGeneral: Soldier
	{
		public LeutenantGeneral(string id, string firstName, string lastName, double salary, SortedSet<PrivateSoldier> privateSoldiers) : base(id, firstName, lastName, salary)
		{
			this.Privates = privateSoldiers;
		}

		public ISet<PrivateSoldier> Privates { get; }

		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:f2}");
			if (Privates.Count > 0)
			{
				sb.AppendLine("Privates:");
				foreach (var privateSoldier in Privates)
				{
					sb.AppendLine($"  {privateSoldier}");
				}
			}
			else
			{
				sb.Append("Privates:");
			}
			return sb.ToString();
		}

		
	}
}
