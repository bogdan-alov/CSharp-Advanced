
using System;
using System.Text;

public abstract class Harvester
{
	private string id;
	private double oreOutput;
	private double energyRequirement;

	public Harvester(string id, double oreOutput, double energyRequirement)
	{
		this.Id = id;
		this.OreOutput = oreOutput;
		this.EnergyRequirement = energyRequirement;
	}

	public double EnergyRequirement
	{
		get { return energyRequirement; }
		set
		{
			if (value > 20000 || value < 0)
			{
				throw new Exception("Harvester is not registered, because of it's EnergyRequirement");
			}
			energyRequirement = value;
		}
	}

	public double OreOutput
	{
		get { return oreOutput; }
		protected set
		{
			if (value < 0)
			{
				throw new Exception("Harvester is not registered, because of it's OreOutput");
			}
			oreOutput = value;
		}
	}


	public string Id
	{
		get { return id; }
		protected set { id = value; }
	}


}

