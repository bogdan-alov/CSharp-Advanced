using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_04.Shopping_Spree
{
	class Person
	{
		private string name;
		private decimal money;
		private List<Product> bagOfProducts;

		public Person(string name, decimal money)
		{
			this.BagOfProducts = new List<Product>();
			this.Name = name;
			this.Money = money;
		}


		public string Name
		{
			get { return this.name; }
			set
			{
				if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException("Name cannot be empty");
				}
				this.name = value;
			}
		}


		public decimal Money
		{
			get { return this.money; }
			set
			{
				if (value < 0)
				{
					throw new Exception("Money cannot be negative");
				}
				this.money = value;
			}
		}


		public List<Product> BagOfProducts
		{
			get { return this.bagOfProducts; }
			set { this.bagOfProducts = value; }
		}

		public void BuyProduct(Product product)
		{
			
			if (product.Cost > money)
			{
				Console.WriteLine($"{name} can't afford {product.Name}");
			}
			else
			{
				bagOfProducts.Add(product);
				money -= product.Cost;
				Console.WriteLine($"{Name} bought {product.Name}");
			}
		}

	}
}
