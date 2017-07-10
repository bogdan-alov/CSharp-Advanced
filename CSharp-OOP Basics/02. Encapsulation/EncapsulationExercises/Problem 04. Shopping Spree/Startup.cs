using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_04.Shopping_Spree
{
	class Startup
	{
		static void Main()
		{
			try
			{
				var input = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
				var users = new List<Person>();
				foreach (var s in input)
				{

					var split = s.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

					users.Add(new Person(split[0], decimal.Parse(split[1])));
				}
				var input2 = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
				var products = new List<Product>();
				foreach (var s in input2)
				{
					var split = s.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
					products.Add(new Product(split[0], decimal.Parse(split[1])));
				}
				var input3 = "";
				while ((input3 = Console.ReadLine()) != "END")
				{
					var array = input3.Split();
					var user = users.FirstOrDefault(c => c.Name == array[0]);
					var product = products.FirstOrDefault(c => c.Name == array[1]);
					
					user.BuyProduct(product);
				
				}
				foreach (var person in users)
				{
					if (person.BagOfProducts.Count >= 1)
					{
						Console.WriteLine($"{person.Name} - {string.Join(", ", person.BagOfProducts)}");
					}
					else
					{
						Console.WriteLine($"{person.Name} - Nothing bought");
					}
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				
			}
		}
	}
}
