using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03.Wild_Farm.Models.Foods
{
	public abstract class Food
	{
		public Food(int quantity)
		{
			this.Quantity = quantity;
		}
		private int quantity;

		public int Quantity
		{
			get { return quantity; }
			set { quantity = value; }
		}

	}
}
