
using System;

public class AirBender : Bender
{
	public AirBender(string name, int power, double aerialIntegrity) : base(name, power)
	{
		this.AerialIntegrity = aerialIntegrity;
		this.TotalPower = power * aerialIntegrity;
	}

	private double aerialIntegrity;

	public double AerialIntegrity
	{
		get { return aerialIntegrity; }
		set { aerialIntegrity = value; }
	}

}


