using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_03.Wild_Farm.Models.Foods;

namespace Problem_03.Wild_Farm.Models.Animals
{
	class Zebra : Mammal
	{
		public Zebra(string name, string type,string livingRegion ,double weight) : base(name, type,livingRegion ,weight)
		{
		}

		public override void Eat(Food food)
		{
			if (food is Vegetable)
			{
				this.FoodEaten += food.Quantity;
			}
			else
			{
				Console.WriteLine("Zebras are not eating that type of food!");
			}
		}

		public override void makeSound()
		{
			Console.WriteLine("Zs");
		}
	}
}
