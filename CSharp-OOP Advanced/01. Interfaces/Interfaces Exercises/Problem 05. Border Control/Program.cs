using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_05.Border_Control.Models;
using Problem_05.Border_Control.Models.Classes;
using Problem_05.Border_Control.Models.Interfaces;

namespace Problem_05.Border_Control
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = "";
			var n = int.Parse(Console.ReadLine());
			var list = new List<IBuyer>();
			for (int i = 0; i < n; i++)
			{
				input = Console.ReadLine();
				var array = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

				if (array.Length == 3  && !list.Any(c=> c.Name == array[0]))
				{
					var rebel = new Rebel(array[0], int.Parse(array[1]), array[2]);
					list.Add(rebel);
				}
				if(array.Length > 3 && !list.Any(c=> c.Name == array[0]))
				{
					var person = new Person(array[0], int.Parse(array[1]), array[2], array[3]);
					list.Add(person);
				}
			}
			
			while ((input = Console.ReadLine()) != "End")
			{

				if (list.Any(c=> c.Name == input))
				{
					list.Where(c=> c.Name == input).ToList().ForEach(c=> c.BuyFood());
				}
				
			}
			Console.WriteLine(list.Sum(c => c.Food));
		}
	}
}
