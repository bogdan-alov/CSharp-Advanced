using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_06.Strategy_Pattern.Comparators
{
	class NameComparator : IComparer<Person>
	{
		public int Compare(Person x, Person y)
		{
			var result = x.Name.Length - y.Name.Length;
			if (result == 0)
			{
				var first = x.Name.ToLower();
				var second = y.Name.ToLower();
				result = first[0].CompareTo(second[0]);

			}

			return result;
		}
	}
}
