using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Problem_02.Custom_List.Model;

namespace Problem_02.Custom_List
{
	class Engine
	{
		public static void Run()
		{
			var input = "";
			var customList = new CustomList<string>();
			while ((input = Console.ReadLine()) != "END")
			{
				var array = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
				switch (array[0])
				{
					case "Add":
						customList.Add(array[1]);
						break;

					case "Remove":
						customList.Remove(int.Parse(array[1]));
						break;
						

					case "Contains":
						Console.WriteLine(customList.Contains(array[1]));
						break;

					case "Swap":
						customList.Swap(int.Parse(array[1]), int.Parse(array[2]));
						break;

					case "Greater":
						Console.WriteLine(customList.CountGreaterThen(array[1]));
						break;

					case "Max":
						Console.WriteLine(customList.Max());
						break;

					case "Min":
						Console.WriteLine(customList.Min());
						break;

					case "Print":
						customList.Print();
						break;

					case "Sort":
						customList.Sort();
						break;
					
				}
			}
		}
	}
}
