using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Problem_01.ListyIterator
{
	class ListyIterator<T> : IEnumerable<T>
	{
		public ListyIterator(params T[] collection)
		{
			this.data = new List<T>(collection);
			currentIndex = 0;
		}

		public int Count => this.data.Count;
		private readonly List<T> data;
		private int currentIndex;


		public bool MoveNext()
		{
			return ++currentIndex < this.data.Count;
		}

		public void Reset()
		{
			currentIndex = -1;
		}

		public bool HasNext()
		{
			if (currentIndex + 1 >= this.data.Count)
			{
				return false;
			}
			return true;
		}

		public T Print()
		{
			if (data.Count == 0)
			{
				throw new Exception("Invalid Operation!");
			}
			return data[currentIndex];
		}


		public IEnumerator<T> GetEnumerator()
		{
			for (int i = 0; i < data.Count; i++)
			{
				yield return this.data[i];
			}
		}


		public void PrintAll()
		{
			foreach (var item in data)
			{
				Console.Write(item + " ");
			}
			Console.WriteLine();
		}
		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
