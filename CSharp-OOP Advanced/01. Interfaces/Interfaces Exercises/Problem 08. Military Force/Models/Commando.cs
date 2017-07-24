using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_08.Military_Force.Models.Interfaces;

namespace Problem_08.Military_Force.Models
{
	class Commando : Soldier, ISpecialisedSoldier
	{
		public Commando(string id, string firstName, string lastName, double salary, string corps) : base(id, firstName, lastName, salary)
		{
			this.Corps = corps;
			this.Missions = new SortedSet<Mission>();
		}
		private string corps;
		public string Corps
		{
			get { return this.corps; }
			private set
			{
				if (!value.Equals("Airforces") && !value.Equals("Marines"))
				{
					throw new Exception("Invalid coprs!");
				}
				this.corps = value;
			}
		}

		public ISet<Mission> Missions { get; set; }

		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:f2}");
			sb.AppendLine($"Corps: {this.Corps}");
			if (Missions.Count > 0)
			{
				sb.AppendLine("Missions:");
				foreach (var mission in Missions)
				{
					if (Missions.Count == 1)
					{
						sb.Append(mission.ToString());
					}
					else
					{
						sb.AppendLine(mission.ToString());
					}
				}
			}
			else
			{
				sb.Append("Missions:");
			}

			return sb.ToString();
		}

		
	}
}
