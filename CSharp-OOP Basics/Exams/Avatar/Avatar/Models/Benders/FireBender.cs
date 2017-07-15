
public class FireBender : Bender
{
	public FireBender(string name, int power, double heatAggression) : base(name, power)
	{
		this.HeatAggression = heatAggression;
		this.TotalPower = heatAggression * power;
	}

	private double heatAggression;

	public double HeatAggression
	{
		get { return heatAggression; }
		set { heatAggression = value; }
	}

}

