using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_01.Generic_Box_of_String.Models
{
	public class Box <T>
		where T : IComparable<T>
	{

		public Box(T name)
		{
			Name = name;
			
		}
		private T name;

		public T Name
		{
			get { return name; }
			private set { name = value; }
		}

		
		public override string ToString()
		{
			return $"{Name.GetType().FullName}: {name}";
		}

		public int Compare(IList<Box<T>> collection, T element)
		{
			return collection.Count(i => i.Name.CompareTo(element) == 1);
		}
	}
}
