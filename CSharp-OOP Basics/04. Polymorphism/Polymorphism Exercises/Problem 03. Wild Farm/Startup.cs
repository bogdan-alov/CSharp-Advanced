using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_03.Wild_Farm.Models.Animals;
using Problem_03.Wild_Farm.Models.Foods;

namespace Problem_03.Wild_Farm
{
	class Startup
	{
		static void Main(string[] args)
		{
			var data = "";

			while ((data = Console.ReadLine()) != "End")
			{
				var foodData = Console.ReadLine().Split();
				var array = data.Split();
				
				
				if (array[0] == "Cat")
				{
					var cat = new Cat(array[1], "Cat",array[3], double.Parse(array[2]), array[4]);
					if (foodData[0] == "Vegetable")
					{
						var vegetable = new Vegetable(int.Parse(foodData[1]));
						cat.makeSound();
						cat.Eat(vegetable);
						Console.WriteLine(cat);
					}
					else
					{
						var meat = new Meat(int.Parse(foodData[1]));
						cat.makeSound();
						cat.Eat(meat);
						Console.WriteLine(cat);
					}
				}
				else if (array[0] == "Tiger")
				{
					var tiger = new Tiger(array[1], "Tiger", array[3] ,double.Parse(array[2]));
					if (foodData[0] == "Vegetable")
					{
						var vegetable = new Vegetable(int.Parse(foodData[1]));
						tiger.makeSound();
						tiger.Eat(vegetable);
						Console.WriteLine(tiger);
					}
					else
					{
						var meat = new Meat(int.Parse(foodData[1]));
						tiger.makeSound();
						tiger.Eat(meat);
						Console.WriteLine(tiger);
					}

				}
				else if (array[0] == "Zebra")
				{
					var zebra = new Zebra(array[1], "Zebra", array[3], double.Parse(array[2]));
					if (foodData[0] == "Vegetable")
					{
						var vegetable = new Vegetable(int.Parse(foodData[1]));
						zebra.makeSound();
						zebra.Eat(vegetable);
						Console.WriteLine(zebra);
					}
					else
					{
						var meat = new Meat(int.Parse(foodData[1]));
						zebra.makeSound();
						zebra.Eat(meat);
						Console.WriteLine(zebra);
					}
				}
				else if (array[0] == "Mouse")
				{
					var mouse = new Mouse(array[1], "Mouse", array[3], double.Parse(array[2]));
					if (foodData[0] == "Vegetable")
					{
						var vegetable = new Vegetable(int.Parse(foodData[1]));
						mouse.makeSound();
						mouse.Eat(vegetable);
						Console.WriteLine(mouse);
					}
					else
					{
						var meat = new Meat(int.Parse(foodData[1]));
						mouse.makeSound();
						mouse.Eat(meat);
						Console.WriteLine(mouse);
					}
				}
			}
		}
	}
}
