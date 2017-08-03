using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_06.Strategy_Pattern
{
	class Person : IComparable<Person>
	{
		public Person(string name, int age)
		{
			Name = name;
			Age = age;
		}
		public string Name { get; private set; }

		public int Age { get; private set; }

		public override string ToString()
		{
			return $"{this.Name} {this.Age}";
		}

		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		public int CompareTo(Person other)
		{
			if (ReferenceEquals(this, other)) return 0;
			if (ReferenceEquals(null, other)) return 1;
			var nameComparison = string.Compare(Name, other.Name, StringComparison.Ordinal);
			if (nameComparison != 0) return nameComparison;
			return Age.CompareTo(other.Age);
		}
	}
}
