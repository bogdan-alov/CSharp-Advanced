
using System.Text;

public class HammerHarvester : Harvester
{
	public HammerHarvester(string id, double oreOutput, double energyRequirement) : base(id, oreOutput, energyRequirement)
	{
		this.OreOutput += 2 * this.OreOutput;
		this.EnergyRequirement += this.EnergyRequirement;
	}

	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.AppendLine($"Hammer Harvester - {this.Id}");
		sb.AppendLine($"Ore Output: {OreOutput}");
		sb.AppendLine($"Energy Requirement: {this.EnergyRequirement}");
		return sb.ToString();
	}
}

