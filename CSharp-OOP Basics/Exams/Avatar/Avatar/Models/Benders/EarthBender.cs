
public class EarthBender : Bender
{
	public EarthBender(string name, int power, double groundSaturation) : base(name, power)
	{
		this.GroundSaturation = groundSaturation;
		this.TotalPower = power * groundSaturation;
	}

	private double groundSaturation;

	public double GroundSaturation
	{
		get { return groundSaturation; }
		set { groundSaturation = value; }
	}

}

