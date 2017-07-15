
public abstract class Monument
{
	public Monument(string name)
	{
		this.Name = name;
	}

	private string name;

	public string Name
	{
		get { return name; }
		set { name = value; }
	}

}

