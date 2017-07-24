using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_08.Military_Force.Models.Interfaces;

namespace Problem_08.Military_Force.Models
{
	class Mission : IMission, IComparable<Mission>
	{
		public Mission(string codeName, string state)
		{
			this.State = state;
			this.CodeName = codeName;
		}
		public void CompleteMission()
		{
			Console.WriteLine($"Mission completed!");
		}

		private string state;
		public string State
		{
			get { return state; }
			private set
			{
				if (!value.Equals("inProgress") && !value.Equals("Finished"))
				{
					throw new Exception("Invalid state name!");
				}
				this.state = value;
			}
		}

		public string CodeName { get; }

		public override string ToString()
		{
			return $"  Code Name: {this.CodeName} State: {this.State}";
		}

		public int CompareTo(Mission other)
		{
			if (ReferenceEquals(this, other)) return 0;
			if (ReferenceEquals(null, other)) return 1;
			var stateComparison = string.Compare(state, other.state, StringComparison.Ordinal);
			if (stateComparison != 0) return stateComparison;
			return string.Compare(CodeName, other.CodeName, StringComparison.Ordinal);
		}
	}
}
