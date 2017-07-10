using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03.Mankind
{
	class Worker : Human
	{
		public Worker(string firstName, string lastName, decimal weekSalary, decimal workHours)
			:base(firstName,lastName)
		{
			this.WeekSalary = weekSalary;
			this.WorkHoursPerDay = workHours;
		}
		private decimal weekSalary;

		public decimal WeekSalary
		{
			get { return weekSalary; }
			set
			{
				if (value <=10)
				{
					throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
				}
				weekSalary = value;
			}
		}


		private decimal workHoursPerDay;

		public decimal WorkHoursPerDay
		{
			get { return workHoursPerDay; }
			set
			{
				if (value < 1 || value > 12)
				{
					throw  new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
				}
				workHoursPerDay = value;
			}
		}

		public decimal CalculateMoneyPerHour()
		{
			return weekSalary / (5 * workHoursPerDay);
		}
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append(base.ToString())
				.AppendLine($"Week Salary: {this.WeekSalary:f2}")
				.AppendLine($"Hours per day: {this.WorkHoursPerDay:f2}")
				.AppendLine($"Salary per hour: {CalculateMoneyPerHour():f2}");

			return sb.ToString();
	
		}
	}
}
