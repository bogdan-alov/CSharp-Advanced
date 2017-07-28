using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_01.Generic_Box_of_String.Models;

namespace Problem_01.Generic_Box_of_String
{
	class Program
	{
		static void Main()
		{
			var n = int.Parse(Console.ReadLine());
			var boxes = new List<Box<double>>();
			for (int i = 0; i < n; i++)
			{
				var newBox = new Box<double>(double.Parse(Console.ReadLine()));
				boxes.Add(newBox);
			}
			var compareElement = double.Parse(Console.ReadLine());

			var box = boxes.FirstOrDefault();
			Console.WriteLine(box.Compare(boxes, compareElement));
		}

		public static void Swap(List<Box<int>> data, int firstIndex, int indexToBeSwapped)
		{
			var tmp = data[firstIndex];
			data[firstIndex] = data[indexToBeSwapped];
			data[indexToBeSwapped] = tmp;
		}
	}
}
