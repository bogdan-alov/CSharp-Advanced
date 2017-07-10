using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10.Car_Salesman
{
	class Startup
	{
		static void Main(string[] args)
		{
			var n1 = int.Parse(Console.ReadLine());
			var engines = new List<Engine>();
			var cars = new List<Car>();
			for (int i = 0; i < n1; i++)
			{
				var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
				var engine = new Engine();
				engine.Model = input[0];
				engine.Power = int.Parse(input[1]);
				if (input.Length == 4)
				{
					engine.Displacement = input[2];
					engine.Efficiency = input[3];

				}
				else if(input.Length == 3)
				{
					if (int.TryParse(input[2], out int result))
					{
						engine.Displacement = input[2];
					}
					else
					{
						engine.Efficiency = input[2];
					}
				}
				engines.Add(engine);
			}
			var n2 = int.Parse(Console.ReadLine());
			for (int i = 0; i < n2; i++)
			{
				var input = Console.ReadLine().Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);
				var car = new Car();
				car.Model = input[0];
				car.Engine = engines.FirstOrDefault(c => c.Model == input[1]);
				if (input.Length == 4)
				{
					car.Weight = input[2];
					car.Color = input[3];
				}
				else if (input.Length == 3)
				{
					if (int.TryParse(input[2], out int result))
					{
						car.Weight = input[2];
					}
					else
					{
						car.Color = input[2];
					}
				}
				cars.Add(car);
			}
			foreach (var car in cars)
			{
				Console.WriteLine(car);
			}
		}
	}
}
