
using System;

public class Circle : Shape
{
	public Circle(double radius)
	{
		this.Radius = radius;
	}
	private double radius;

	public double Radius
	{
		get { return radius; }
		set { radius = value; }
	}

	public override double CalculatePerimeter()
	{
		return 2 * (Math.PI * this.Radius);
	}

	public override double CalculateArea()
	{
		return Math.PI * Math.Pow(this.Radius, 2);

	}

	public sealed override string Draw()
	{
		return base.Draw() + "Circle";
	}
}

