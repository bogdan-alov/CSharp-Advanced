
public class WaterMonument : Monument
{
	public WaterMonument(string name, int watterAffinity) : base(name)
	{
		this.WatterAffinity = watterAffinity;
	}

	private int watterAffinity;

	public int WatterAffinity
	{
		get { return watterAffinity; }
		set { watterAffinity = value; }
	}

}

