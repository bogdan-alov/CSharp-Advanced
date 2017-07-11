using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03.Wild_Farm.Models.Animals
{
	public abstract class Mammal : Animal
	{
		public Mammal(string name, string type,string livingRegion, double weight) : base(name, weight)
		{
			this.Type = type;
			this.LivingRegion = livingRegion;
		}

		private string livingRegion;

		public string LivingRegion
		{
			get { return livingRegion; }
			set { livingRegion = value; }
		}

		public override string ToString()
		{
			return $"{GetType().Name}[{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
		}
	}
}
