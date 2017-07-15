
using System.Text;

public abstract class Car
{
	public Car(string brand, string model, int yearOfProduction, int horsePower, int acceleration,int suspension ,int durability)
	{
		this.Brand = brand;
		this.Model = model;
		this.YearOfProduction = yearOfProduction;
		this.HorsePower = horsePower;
		this.Acceleration = acceleration;
		this.Suspension = suspension;
		this.Durability = durability;
	}
	private string brand;
	private string model;
	private int yearOfProduction;
	private int horsePower;
	private int acceleration;
	private int suspension;
	private int durability;




	public int Suspension
	{
		get { return suspension; }
		set { suspension = value; }
	}

	public int Durability
	{
		get { return durability; }
		set { durability = value; }
	}

	public int Acceleration
	{
		get { return acceleration; }
		set { acceleration = value; }
	}

	public int HorsePower
	{
		get { return horsePower; }
		set { horsePower = value; }
	}

	public int YearOfProduction
	{
		get { return yearOfProduction; }
		set { yearOfProduction = value; }
	}

	public string Model
	{
		get { return model; }
		set { model = value; }
	}

	public string Brand
	{
		get { return brand; }
		set { brand = value; }
	}

	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.AppendLine($"{this.Brand} {this.Model} {this.YearOfProduction}");
		sb.AppendLine($"{this.HorsePower} HP, 100 m/h in {this.Acceleration} s");
		sb.AppendLine($"{this.Suspension} Suspension force, {this.Durability} Durability");
		return sb.ToString();
	}

	public virtual void Tune(int tuneIndex, string addOn)
	{
		this.HorsePower += tuneIndex;
		this.Suspension += tuneIndex / 2;

	}
}

