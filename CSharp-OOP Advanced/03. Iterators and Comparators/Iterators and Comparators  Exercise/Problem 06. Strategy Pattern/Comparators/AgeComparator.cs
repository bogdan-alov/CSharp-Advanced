using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_06.Strategy_Pattern.Comparators
{
	class AgeComparator : IComparer<Person>
	{
		public int Compare(Person x, Person y)
		{
			var result = x.Age - y.Age;

			return result;
		}
	}
}
