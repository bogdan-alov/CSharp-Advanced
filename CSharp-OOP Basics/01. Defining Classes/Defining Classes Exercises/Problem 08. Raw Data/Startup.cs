using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_08.Raw_Data
{
	class Startup
	{
		static void Main(string[] args)
		{

			var n = int.Parse(Console.ReadLine());
			var cars = new Dictionary<string, Car>();
			for (int i = 0; i < n; i++)
			{
				var input = Console.ReadLine().Split();

				var car = new Car();
				car.Model = input[0];
				car.Engine.Power = int.Parse(input[2]);
				car.Engine.Speed = int.Parse(input[1]);
				car.Cargo.Weight = int.Parse(input[3]);
				car.Cargo.Type = input[4];
				for (int t = 5; t < input.Length; t = t + 2)
				{
					var tire = new Tire();
					tire.Pressure = double.Parse(input[t]);
					tire.Age = int.Parse(input[t + 1]);
					car.Tires.Add(tire);
				}
				cars.Add(car.Model, car);
			}

			var type = Console.ReadLine();
			if (type == "fragile")
			{
				foreach (var car in cars.Values.Where(c=> c.Tires.Any(x=> x.Pressure < 1) && c.Cargo.Type == "fragile"))
				{
					Console.WriteLine(car.Model);
				}
			}
			else if(type == "flamable")
			{
				var flamableCars = cars.Values.Where(c => c.Engine.Power > 250 && c.Cargo.Type == "flamable").ToList();
				foreach (var car in flamableCars)
				{
					Console.WriteLine(car.Model);
				}
			}
		}
	}
}
