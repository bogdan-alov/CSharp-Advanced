
using System;

public class Program
{
	public static void Main(string[] args)
	{
		CoffeeMachine machine = new CoffeeMachine();
		string input;
		while ((input = Console.ReadLine()) != "End")
		{
			string[] inputArgs = input.Split();
			if (inputArgs.Length == 1)
			{
				machine.InsertCoin(inputArgs[0]);
			}
			else
			{
				machine.BuyCoffee(inputArgs[0], inputArgs[1]);

			}
		}

		foreach (var machineCoffeesType in machine.CoffeesTypes)
		{
			Console.WriteLine(machineCoffeesType);
		}
	}
}

