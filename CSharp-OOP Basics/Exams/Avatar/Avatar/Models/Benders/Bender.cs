
public abstract class Bender
{
	public Bender(string name, int power)
	{
		this.Name = name;
		this.Power = power;
	}

	private string name;
	private int power;
	private double totalPower;

	public double TotalPower
	{
		get { return totalPower; }
		set { totalPower = value; }
	}

	public int Power
	{
		get { return power; }
		set { power = value; }
	}

	public string Name
	{
		get { return name; }
		set { name = value; }
	}

}

