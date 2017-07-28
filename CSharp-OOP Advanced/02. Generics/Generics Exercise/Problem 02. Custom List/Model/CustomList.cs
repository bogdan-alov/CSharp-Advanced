using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_02.Custom_List.Model
{
	class CustomList<T> : IEnumerable<T>
		where T : IComparable<T>
	{
		private IList<T> data;

		public CustomList()
		{
			this.data = new List<T>();
		}

		public void Add(T element)
		{
			this.data.Add(element);
		}

		public void Remove(int index)
		{
			this.data.RemoveAt(index);
		}

		public bool Contains(T element)
		{
			return this.data.Contains(element);
		}

		public void Swap(int firstIndex, int secondIndex)
		{
			var temp = this.data[firstIndex];
			this.data[firstIndex] = this.data[secondIndex];
			this.data[secondIndex] = temp;
		}

		public int CountGreaterThen(T element)
		{
			return this.data.Count(c => c.CompareTo(element) == 1);
		}

		public T Max()
		{
			return this.data.Max();
		}


		public T Min()
		{
			return this.data.Min();
		}

		public void Print()
		{
			foreach (var element in data)
			{
				Console.WriteLine(element);
			}
		}

		public void Sort()
		{
			this.data = this.data.OrderBy(c => c).ToList();
		}

		public IEnumerator<T> GetEnumerator()
		{
			return data.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return data.GetEnumerator();
		}
	}
}
