using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03.Wild_Farm.Models.Animals
{
	abstract class Felime : Mammal
	{
		public Felime(string name, string type,string livingRegion, double weight) : base(name, type, livingRegion,weight)
		{
		}
	}
}
