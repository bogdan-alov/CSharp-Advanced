using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03.Wild_Farm.Models.Foods
{
	class Vegetable : Food
	{
		public Vegetable(int quantity)
			: base(quantity)

		{
			this.Quantity = quantity;
		}
	}
}
