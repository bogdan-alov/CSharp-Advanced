using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_06.Animals
{
	class Kittens : Animal
	{
		public Kittens(string name, int age)
			:base(name,age,"Female")
		{
		}
		public override string ProduceSound()
		{
			return "Miau";
		}
	}
}
