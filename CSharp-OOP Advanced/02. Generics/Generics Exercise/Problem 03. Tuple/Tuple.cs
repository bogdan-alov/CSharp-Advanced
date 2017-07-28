using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03.Tuple
{
	class Tuple<T, U, C>
	{
		public Tuple(T item1, U item2, C item3)
		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
		}
		private T item1;
		private U item2;
		private C item3;

		public C Item3
		{
			get { return item3; }
			set { item3 = value; }
		}

		public U Item2
		{
			get { return item2; }
			protected set{ item2 = value; }
		}

		public T Item1
		{
			get { return item1; }
			protected set { item1 = value; }
		}

		public override string ToString()
		{
			return $"{Item1} -> {Item2} -> {Item3}";
		}
	}
}
