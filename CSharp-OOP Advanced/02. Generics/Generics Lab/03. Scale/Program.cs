
using System;

public class Program
{
	public static void Main(string[] args)
	{ 
		Scale<int> scale = new Scale<int>(1,2);

		Console.WriteLine(scale.GetHavier());
	}
}

