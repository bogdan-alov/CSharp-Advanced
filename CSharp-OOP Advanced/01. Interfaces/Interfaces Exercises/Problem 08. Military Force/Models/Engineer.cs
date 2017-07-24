using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_08.Military_Force.Models.Interfaces;

namespace Problem_08.Military_Force.Models
{
	class Engineer : Soldier, ISpecialisedSoldier
	{

		public Engineer(string id, string firstName, string lastName, double salary, string corps) : base(id, firstName, lastName, salary)
		{
			this.Corps = corps;
			this.Repairs = new SortedSet<Repair>();
		}

		public ISet<Repair> Repairs { get; set; }
		
		private string corps;
		public string Corps
		{
			get { return this.corps; }
			private set
			{
				if (value != "Airforces" && !value.Equals("Marines"))
				{
					throw new Exception("Invalid coprs!");
				}
				this.corps = value;
			}
		}

		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:f2}");
			sb.AppendLine($"Corps: {this.Corps}");
			if (Repairs.Count > 0)
			{
				sb.AppendLine("Repairs:");
				foreach (var repair in Repairs)
				{
					if (Repairs.Count == 1)
					{
						sb.Append(repair);
					}
					else
					{
						sb.AppendLine(repair.ToString());
					}
				}
			}
			else
			{
				sb.Append("Repairs:");
			}
			return sb.ToString();
		}
	}
}
