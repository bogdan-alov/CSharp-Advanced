using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Froggy
{
	class Lake : IEnumerable<int>
	{
		public Lake(params int[] input)
		{
			this.data = new List<int>(input);
		}
		private List<int> data;

		public IEnumerator<int> GetEnumerator()
		{
			var even = new List<int>();
			var odd = new List<int>();
			for (int i = 0; i < data.Count; i++)
			{
				if (i % 2 == 0)
				{
					odd.Add(data[i]);
				}
				else
				{
					even.Add(data[i]);
				}
			}
			even.Reverse();
			data.Clear();
			data.AddRange(odd);
			data.AddRange(even);

			for (int i = 0; i < data.Count; i++)
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
