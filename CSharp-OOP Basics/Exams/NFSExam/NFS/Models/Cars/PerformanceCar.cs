
using System.Collections.Generic;
using System.Text;

class PerformanceCar : Car
{
	public PerformanceCar(string brand, string model, int yearOfProduction, int horsePower, int acceleration, int suspension ,int durability) : base(brand, model, yearOfProduction, horsePower, acceleration, suspension ,durability)
	{
		this.HorsePower +=(horsePower * 50) / 100;
		this.Suspension -=  this.Suspension / 4;
		this.AddOns = new List<string>();
	}
	private List<string> addOns;

	public List<string> AddOns
	{
		get { return addOns; }
		set { addOns = value; }
	}

	public override string ToString()
	{
		var result = new StringBuilder(base.ToString());
		if (AddOns.Count > 0)
		{
			result.AppendLine($"Add-ons: {string.Join(", ", AddOns)}");
		}
		else
		{
			result.AppendLine("Add-ons: None");
		}
		return result.ToString().Trim();
	}

	public override void Tune(int tuneIndex, string addOn)
	{
		base.Tune(tuneIndex, addOn);

		this.AddOns.Add(addOn);
	}
}
