
public class WaterBender : Bender
{
	public WaterBender(string name, int power, double waterClarity) : base(name, power)
	{
		this.WaterClarity = waterClarity;
		this.TotalPower = waterClarity * power;
	}

	private double waterClarity;

	public double WaterClarity
	{
		get { return waterClarity; }
		set { waterClarity = value; }
	}

}

