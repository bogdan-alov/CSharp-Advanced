
public class Tesla : ICar, IElectricCar
{
	public Tesla(string model, string color, int battery)
	{
		this.Model = model;
		this.Color = color;
		this.Battery = battery;
	}
	public string Model { get; set; }
	public string Color { get; set; }
	public string Start()
	{
		return "";
	}

	public string Stop()
	{
		return "";
	}

	public int Battery { get; set; }

	public override string ToString()
	{
		return $" ";
	}
}

