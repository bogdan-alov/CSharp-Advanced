
using System.Text;

public class SonicHarvester : Harvester
{
	private int sonicFactor;

	public SonicHarvester(string id, double oreOutput, double energyRequirement, int sonicFactor) : base(id, oreOutput, energyRequirement)
	{
		this.SonicFactor = sonicFactor;
		this.EnergyRequirement /= sonicFactor;
	}

	public int SonicFactor
	{
		get { return sonicFactor; }
		protected set { sonicFactor = value; }
	}

	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.AppendLine($"Sonic Harvester - {this.Id}");
		sb.AppendLine($"Ore Output: {OreOutput}");
		sb.AppendLine($"Energy Requirement: {this.EnergyRequirement}");
		return sb.ToString();
	}
}

