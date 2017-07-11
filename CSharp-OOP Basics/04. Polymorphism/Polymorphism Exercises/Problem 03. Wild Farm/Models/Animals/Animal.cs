using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_03.Wild_Farm.Models.Foods;

namespace Problem_03.Wild_Farm.Models.Animals
{
	public abstract class Animal
	{
		public Animal(string name, double weight)
		{
			this.Name = name;
			this.Weight = weight;

		}

		private string name;
		private string type;
		private double weight;
		private int foodEaten;



		public int FoodEaten
		{
			get { return foodEaten; }
			set { foodEaten = value; }
		}

		public double Weight
		{
			get { return weight; }
			set { weight = value; }
		}

		public string Type
		{
			get { return type; }
			set { type = value; }
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public virtual void makeSound()
		{
			
		}

		public virtual void Eat(Food food)
		{
			
		}
	}
}
