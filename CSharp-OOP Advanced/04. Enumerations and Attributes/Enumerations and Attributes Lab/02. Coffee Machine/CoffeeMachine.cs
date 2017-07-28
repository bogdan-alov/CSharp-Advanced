
using System;
using System.Collections.Generic;
using System.Linq;

public class CoffeeMachine
{
	public CoffeeMachine()
	{
		this.data = new List<CoffeeType>();
	}
	private IList<CoffeeType> data;
	private int coins;
	public IEnumerable<CoffeeType> CoffeesTypes
	{
		get { return data; }
	}

	public void InsertCoin(string coin)
	{
		var coinToAdd = (int)Enum.Parse(typeof(Coin), coin);
		this.coins += coinToAdd;
	}

	public void BuyCoffee(string size, string type)
	{
		var coffeType = (CoffeeType) Enum.Parse(typeof(CoffeeType), type);
		var price = (int) Enum.Parse(typeof(CoffeePrice), size);
		if (coins >= price)
		{
			data.Add(coffeType);
			coins = 0;
		}
	}
}

