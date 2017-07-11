
public class Rectangle : Shape
{
	public Rectangle(double width, double height)
	{
		this.Width = width;
		this.Height = height;
	}
	private double width;
	private double height;

	public double Height
	{
		get { return height; }
		set { height = value; }
	}

	public double Width
	{
		get { return width; }
		set { width = value; }
	}

	public override double CalculatePerimeter()
	{
		return 2 * width + 2 * height;
	}

	public override double CalculateArea()
	{
		return width * height;
	}

	public sealed override string Draw()
	{
		return base.Draw() + "Rectangle";
	}
}

