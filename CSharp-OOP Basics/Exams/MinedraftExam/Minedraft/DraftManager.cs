using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DraftManager
{
	private string mode;
	private List<Harvester> harvesters;
	private List<Provider> providers;
	private double totalEnergy;
	private double totalOre;
	
	public DraftManager()
	{
		this.harvesters = new List<Harvester>();
		this.providers = new List<Provider>();
		this.mode =  = "Full";
	}
	public string RegisterHarvester(List<string> arguments)
	{
		var type = arguments[0];
		var id = arguments[1];
		var oreOutput = double.Parse(arguments[2]);
		var energyRequirement = double.Parse(arguments[3]);
		var sonicFactor = 0;
		if (arguments.Count == 5)
		{
			sonicFactor = int.Parse(arguments[4]);
		}
		try
		{
			if (type == "Sonic")
			{
				var sonicHarvester = new SonicHarvester(id, oreOutput, energyRequirement, sonicFactor);
				harvesters.Add(sonicHarvester);
			}
			else
			{
				var hammerHarvester = new HammerHarvester(id, oreOutput, energyRequirement);
				harvesters.Add(hammerHarvester);
			}
		}
		catch (Exception e)
		{
			return e.Message;
		}
		return $"Successfully registered {type} Harvester - {id}";
	}


	public string RegisterProvider(List<string> arguments)
	{
		var type = arguments[0];
		var id = arguments[1];
		var energyOutput = double.Parse(arguments[2]);
		try
		{
			if (type == "Pressure")
			{
				var pressureProvider = new PressureProvider(id, energyOutput);
				providers.Add(pressureProvider);
			}
			if (type == "Solar")
			{
				var solarProvider = new SolarProvider(id, energyOutput);
				providers.Add(solarProvider);
			}
		}
		catch (Exception e)
		{
			return e.Message;
		}
		return $"Successfully registered {type} Provider - {id}";
	}

	public string Day()
	{
		var sb = new StringBuilder();
		double ore = 0;
		double energyProvided = 0;
		double energyRequired = 0;
		if (mode.Equals("Full"))
		{
			energyProvided = providers.Sum(c => c.EnergyOutput);
			energyRequired = harvesters.Sum(c => c.EnergyRequirement);
			totalEnergy += energyProvided;
			if (totalEnergy >= energyRequired)
			{
				ore = harvesters.Sum(c => c.OreOutput);
				totalOre += ore;
				totalEnergy -= energyRequired;
			}
		}
		else if (mode.Equals("Half"))
		{
			energyProvided = providers.Sum(c => c.EnergyOutput);
			energyRequired = harvesters.Sum(c => c.EnergyRequirement) * 0.6;
			totalEnergy += energyProvided;
			if (totalEnergy >= energyRequired)
			{
				ore = harvesters.Sum(c => c.OreOutput) / 2;
				totalOre += ore;
				totalEnergy -= energyRequired;
			}

		}
		else if (mode.Equals("Energy"))
		{
			energyProvided = providers.Sum(c => c.EnergyOutput);
			totalEnergy += energyProvided;
		}
		sb.AppendLine("A day has passed.");
		sb.AppendLine($"Energy Provided: {energyProvided}");
		sb.AppendLine($"Plumbus Ore Mined: {ore}");
		return sb.ToString();
	}

	public string Mode(List<string> arguments)
	{
		var givenMode = arguments[0];
		mode = givenMode;
		return $"Successfully changed working mode to {givenMode} Mode";
	}

	public string Check(List<string> arguments)
	{
		var id = arguments[0];
		if (providers.Any(c => c.Id == id))
		{
			var provider = providers.FirstOrDefault(c => c.Id == id).ToString();
			return provider;
		}
		if (harvesters.Any(c => c.Id == id))
		{
			var harvester = harvesters.FirstOrDefault(c => c.Id == id).ToString();
			return harvester;
		}
		return $"No element found with id - {id}";
	}
	public string ShutDown()
	{
		var sb = new StringBuilder();
		sb.AppendLine("System Shutdown");
		sb.AppendLine($"Total Energy Stored: {totalEnergy}");
		sb.AppendLine($"Total Mined Plumbus Ore: {totalOre}");
		return sb.ToString();
	}
}

