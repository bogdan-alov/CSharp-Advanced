using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_08.Military_Force.Models.Interfaces;

namespace Problem_08.Military_Force.Models
{
	class Repair : IRepair, IComparable<Repair>
	{
		public Repair(string partName, int hoursWorked)
		{
			this.PartName = partName;
			this.HoursWorked = hoursWorked;
		}
		public string PartName { get; }
		public int HoursWorked { get; }

		public override string ToString()
		{
			return $"  Part Name: {this.PartName} Hours Worked: {this.HoursWorked}";
		}


		public int CompareTo(Repair other)
		{
			if (ReferenceEquals(this, other)) return 0;
			if (ReferenceEquals(null, other)) return 1;
			var partNameComparison = string.Compare(PartName, other.PartName, StringComparison.Ordinal);
			if (partNameComparison != 0) return partNameComparison;
			return HoursWorked.CompareTo(other.HoursWorked);
		}
	}
}
