
public class FireMonument : Monument
{
	public FireMonument(string name, int fireAffinity) : base(name)
	{
		this.FireAffinity = fireAffinity;
	}

	private int fireAffinity;

	public int FireAffinity
	{
		get { return fireAffinity; }
		set { fireAffinity = value; }
	}

}

