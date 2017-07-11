using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_03.Wild_Farm.Models.Foods;

namespace Problem_03.Wild_Farm.Models.Animals
{
	class Cat : Mammal
	{
		public Cat(string name, string type, string livingRegion ,double weight, string breed ) : base(name, type,livingRegion, weight)
		{
			this.Breed = breed;
		}

		private string breed;

		public string Breed
		{
			get { return breed; }
			set { breed = value; }
		}

		public override void makeSound()
		{
			Console.WriteLine("Meowwww");
		}

		public override void Eat(Food food)
		{
			this.FoodEaten += food.Quantity;
		}

		public override string ToString()
		{
			return $"Cat[{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
		}
	}
}
