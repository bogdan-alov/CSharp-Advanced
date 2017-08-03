using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03.Stack
{
	class Stack<T> : IEnumerable<T>
	{
		public Stack()
		{
			this.data = new List<T>();
			this.currentIndex = 0;
		}
		private List<T> data;
		private int currentIndex;

		public void Pop()
		{
			if (data.Count > 0)
			{
				data.RemoveAt(this.data.Count - 1);
			}
			else
			{
				Console.WriteLine("No elements");
			}
		}

		public void Push(params T[] items)
		{
			data.AddRange(items);
		}

		public IEnumerator<T> GetEnumerator()
		{
			for (int i = data.Count - 1; i >= 0; i--)
			{
				yield return data[i];
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
