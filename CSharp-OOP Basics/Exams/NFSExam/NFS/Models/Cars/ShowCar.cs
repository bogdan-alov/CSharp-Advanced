
using System.Text;

class ShowCar : Car
{
	public ShowCar(string brand, string model, int yearOfProduction, int horsePower, int acceleration, int suspension, int durability) : base(brand, model, yearOfProduction, horsePower, acceleration, suspension, durability)
	{
	}

	private int stars;

	public int Stars
	{
		get { return stars; }
		set { stars = value; }
	}

	public override string ToString()
	{
		var result = new StringBuilder(base.ToString());
		result.AppendLine($"{this.Stars} *");
		return result.ToString().Trim();
	}

	public override void Tune(int tuneIndex, string addOn)
	{
		base.Tune(tuneIndex, addOn);

		this.Stars += tuneIndex;
	}
}

