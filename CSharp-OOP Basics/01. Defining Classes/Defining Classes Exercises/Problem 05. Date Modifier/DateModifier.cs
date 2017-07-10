using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_05.Date_Modifier
{
	class DateModifier
	{

		public DateTime firstDate;

		public DateTime secondDate;


		public DateModifier(DateTime firstDate, DateTime secondDate)
		{
			this.firstDate = firstDate;
			this.secondDate = secondDate;
		}
		public int Difference()
		{

			return Math.Abs((int)(firstDate - secondDate).TotalDays);
		}
	}
}
