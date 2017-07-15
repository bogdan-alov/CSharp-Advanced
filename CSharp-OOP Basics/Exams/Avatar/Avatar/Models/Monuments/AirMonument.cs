
public class AirMonument : Monument
{
	public AirMonument(string name, int airAffinity) : base(name)
	{
		this.AirAffinity = airAffinity;
	}

	private int airAffinity;

	public int AirAffinity
	{
		get { return airAffinity; }
		set { airAffinity = value; }
	}

}

