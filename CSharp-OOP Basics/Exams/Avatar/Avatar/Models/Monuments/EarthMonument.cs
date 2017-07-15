
public class EarthMonument : Monument
{
	public EarthMonument(string name, int earthAffinity) : base(name)
	{
		this.EarthAffinity = earthAffinity;
	}

	private int earthAffinity;

	public int EarthAffinity
	{
		get { return earthAffinity; }
		set { earthAffinity = value; }
	}

}


