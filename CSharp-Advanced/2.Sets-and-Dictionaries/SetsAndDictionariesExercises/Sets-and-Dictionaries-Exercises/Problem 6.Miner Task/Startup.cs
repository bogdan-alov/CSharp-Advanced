using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Miner_Task
{
	class Startup
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			var materials = new Dictionary<string, int>();
			var quantity = 0;
			while (input != "stop")
			{
				if (!materials.ContainsKey(input))
				{
					quantity = int.Parse(Console.ReadLine());
					materials.Add(input, quantity);
				}
				else
				{
					quantity = int.Parse(Console.ReadLine());
					materials[input] += quantity;
				}
				input = Console.ReadLine();
			}
			foreach (var material in materials)
			{
				Console.WriteLine($"{material.Key} -> {material.Value}");
			}

		}
	}
}
