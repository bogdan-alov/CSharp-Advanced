using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_03.Wild_Farm.Models.Foods;

namespace Problem_03.Wild_Farm.Models.Animals
{
	class Mouse : Mammal
	{
		public Mouse(string name, string type,string livingRegion ,double weight) : base(name, type,livingRegion ,weight)
		{
		}

		public override void makeSound()
		{
			Console.WriteLine("SQUEEEAAAK!");
		}

		public override void Eat(Food food)
		{
			if (food is Vegetable)
			{
				this.FoodEaten += food.Quantity;
			}
			else
			{
				Console.WriteLine("Mouses are not eating that type of food!");
			}
		}
	}
}
