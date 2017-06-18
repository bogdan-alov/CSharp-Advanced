using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_13.Office_Stuff
{
	class Startup
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			string[] input = new string[n];
			var companies = new Dictionary<string,Dictionary<string,int>>();
			for (int i = 0; i < n; i++)
			{
				input = Console.ReadLine().Split(new char[] { ' ', '|', '-' }, StringSplitOptions.RemoveEmptyEntries);
				var company = input[0];
				var product = input[2];
				var quantity = int.Parse(input[1]);
				if (!companies.ContainsKey(company))
				{
					companies.Add(company, new Dictionary<string, int>());
					companies[company].Add(product,quantity);
				}
				else
				{
					if (!companies[company].ContainsKey(product))
					{
						companies[company].Add(product, quantity);
					}
					else
					{
						companies[company][product] += quantity;
					}
				}
			}
			foreach (var company in companies.OrderBy(c=> c.Key))
			{
				Console.Write($"{company.Key}: ");
				var counter = 1;
				foreach (var product in company.Value)
				{
					if (counter == company.Value.Count)
					{
						Console.Write($"{product.Key}-{product.Value}");
						Console.WriteLine();
						break;
					}
					Console.Write($"{product.Key}-{product.Value}, ");
					counter++;
				}
			}
		}
	}

}
