
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class NationsBuilder
{
	private List<AirMonument> airMonuments;
	private List<WaterMonument> waterMonuments;
	private List<EarthMonument> earthMonuments;
	private List<FireMonument> fireMonuments;

	private List<AirBender> airBenders;
	private List<WaterBender> waterBenders;
	private List<EarthBender> earthBenders;
	private List<FireBender> fireBenders;

	public NationsBuilder()
	{
		this.airBenders = new List<AirBender>();
		this.earthBenders = new List<EarthBender>();
		this.fireBenders = new List<FireBender>();
		this.waterBenders = new List<WaterBender>();


		this.fireMonuments = new List<FireMonument>();
		this.waterMonuments = new List<WaterMonument>();
		this.airMonuments = new List<AirMonument>();
		this.earthMonuments = new List<EarthMonument>();

		this.wars = new List<string>();
	}
	private List<string> wars;
	public void AssignBender(string type,string name, int power, double secondaryParameter)
	{
		if (type == "Air")
		{
			var airBender = new AirBender(name,power,secondaryParameter);
			airBenders.Add(airBender);
		}
		else if (type == "Water")
		{
			var waterBender = new WaterBender(name, power, secondaryParameter);
			waterBenders.Add(waterBender);
		}
		else if (type == "Fire")
		{
			var fireBender = new FireBender(name, power, secondaryParameter);
			fireBenders.Add(fireBender);
		}
		else if (type ==  "Earth")
		{
			var earthBender = new EarthBender(name, power, secondaryParameter);
			earthBenders.Add(earthBender);
		}

	}

	public void AssignMonument(string type, string name, int affinity)
	{
		if (type == "Air")
		{
			var airMonument = new AirMonument(name, affinity);
			airMonuments.Add(airMonument);
		}
		else if (type == "Water")
		{
			var waterMonument = new WaterMonument(name, affinity);
			waterMonuments.Add(waterMonument);
		}
		else if (type == "Fire")
		{
			var fireMonument = new FireMonument(name, affinity);
			fireMonuments.Add(fireMonument);
		}
		else if (type == "Earth")
		{
			var earthMonument = new EarthMonument(name, affinity);
			earthMonuments.Add(earthMonument);
		}
	}

	public string GetStatus(string nationsType)
	{
		var sb = new StringBuilder();
		if (nationsType == "Air")
		{
			sb.AppendLine("Air Nation");
			
			if (airBenders.Count == 0)
			{
				sb.AppendLine("Benders: None");
			}
			else
			{
				sb.AppendLine("Benders: ");
				foreach (var airBender in airBenders)
				{
					sb.AppendLine(
						$"###Air Bender: {airBender.Name}, Power: {airBender.Power}, Aerial Integrity: {airBender.AerialIntegrity:f2}");
				}
			}
			
			if (airMonuments.Count == 0)
			{
				sb.AppendLine("Monuments: None");
			}
			else
			{
				sb.AppendLine("Monuments: ");
				foreach (var airMonument in airMonuments)
				{
					sb.AppendLine($"###Air Monument: {airMonument.Name}, Air Affinity: {airMonument.AirAffinity}");
				}
			}
		}
		else if (nationsType == "Water")
		{
			sb.AppendLine("Water Nation");
			
			if (waterBenders.Count == 0)
			{
				sb.AppendLine("Benders: None");
			}
			else
			{
				sb.AppendLine("Benders: ");
				foreach (var waterBender in waterBenders)
				{
					sb.AppendLine(
						$"###Water Bender: {waterBender.Name}, Power: {waterBender.Power}, Water Clarity: {waterBender.WaterClarity:f2}");
				}
			}
			
			if (waterMonuments.Count == 0)
			{

				sb.AppendLine("Monuments: None");
			}
			else
			{
				sb.AppendLine("Monuments: ");
				foreach (var waterMonument in waterMonuments)
				{
					sb.AppendLine($"###Water Monument: {waterMonument.Name}, Water Affinity: {waterMonument.WatterAffinity}");
				}
			}
		}
		else if (nationsType == "Fire")
		{
			sb.AppendLine("Fire Nation");
			
			if (fireBenders.Count == 0)
			{
				sb.AppendLine("Benders: None");
			}
			else
			{
				sb.AppendLine("Benders: ");
				foreach (var fireBender in fireBenders )
				{
					sb.AppendLine(
						$"###Fire Bender: {fireBender.Name}, Power: {fireBender.Power}, Heat Aggression: {fireBender.HeatAggression:f2}");
				}
			}
			
			if (fireMonuments.Count == 0)
			{
				sb.AppendLine("Monuments: None");
			}
			else
			{
				sb.AppendLine("Monuments: ");
				foreach (var fireMonument in fireMonuments)
				{
					sb.AppendLine($"###Fire Monument: {fireMonument.Name}, Fire Affinity: {fireMonument.FireAffinity}");
				}
			}
		}
		else if (nationsType == "Earth")
		{
			sb.AppendLine("Earth Nation");
			
			if (earthBenders.Count == 0)
			{
				sb.AppendLine("Benders: None");
			}
			else
			{
				sb.AppendLine("Benders: ");
				foreach (var earthBender in earthBenders)
				{
					sb.AppendLine(
						$"###Earth Bender: {earthBender.Name}, Power: {earthBender.Power}, Ground Saturation: {earthBender.GroundSaturation:f2}");
				}
			}
			
			if (earthMonuments.Count == 0)
			{
				sb.AppendLine("Monuments: None");
			}
			else
			{
				sb.AppendLine("Monuments: ");
				foreach (var earthMonument in earthMonuments)
				{
					sb.AppendLine($"###Earth Monument: {earthMonument.Name}, Earth Affinity: {earthMonument.EarthAffinity}");
				}
			}
		}

		return sb.ToString();
	}

	public void IssueWar(string nationsType)
	{
		var airBendersTotalPower = airBenders.Sum(c => c.TotalPower);
		var airMonumentAffinity = airMonuments.Sum(c => c.AirAffinity);
		var airMonumentsTotalPower = (airBendersTotalPower / 100) * airMonumentAffinity;
		var airTotalPower = airBendersTotalPower + airMonumentsTotalPower;

		var waterBendersTotalPower = waterBenders.Sum(c => c.TotalPower);
		var waterMonumentAffinity = waterMonuments.Sum(c => c.WatterAffinity);
		var waterMonumentsTotalPower = (waterBendersTotalPower / 100) * waterMonumentAffinity;
		var waterTotalPower = waterBendersTotalPower + waterMonumentsTotalPower;

		var fireBendersTotalPower = fireBenders.Sum(c => c.TotalPower);
		var fireMonumentAffinity = fireMonuments.Sum(c => c.FireAffinity);
		var fireMonumentsTotalPower = (fireBendersTotalPower / 100) * fireMonumentAffinity;
		var fireTotalPower = fireBendersTotalPower + fireMonumentsTotalPower;

		var earthBendersTotalPower = earthBenders.Sum(c => c.TotalPower);
		var earthMonumentAffinity = earthMonuments.Sum(c => c.EarthAffinity);
		var earthMonumentsTotalPower = (earthBendersTotalPower / 100) * earthMonumentAffinity;
		var earthTotalPower = earthBendersTotalPower + earthMonumentsTotalPower;
		if (earthTotalPower > airTotalPower && earthTotalPower > waterTotalPower && earthTotalPower > fireTotalPower)
		{
			airBenders.Clear();
			airMonuments.Clear();

			waterMonuments.Clear();
			waterBenders.Clear();
			
			fireBenders.Clear();
			fireMonuments.Clear();
			
		}
		else if (airTotalPower > earthTotalPower && airTotalPower > fireTotalPower && airTotalPower > waterTotalPower)
		{
			waterMonuments.Clear();
			waterBenders.Clear();

			fireBenders.Clear();
			fireMonuments.Clear();

			earthBenders.Clear();
			earthMonuments.Clear();
		}
		else if (fireTotalPower > airTotalPower && fireTotalPower > earthTotalPower && fireTotalPower > waterTotalPower)
		{
			earthBenders.Clear();
			earthMonuments.Clear();

			waterMonuments.Clear();
			waterBenders.Clear();

			airBenders.Clear();
			airMonuments.Clear();
		}
		else 
		{
			airBenders.Clear();
			airMonuments.Clear();

			earthBenders.Clear();
			earthMonuments.Clear();

			fireBenders.Clear();
			fireMonuments.Clear();
		}

		wars.Add(nationsType);
	}

	public string GetWarsRecord()
	{
		var sb = new StringBuilder();
		var counter = 0;
		foreach (var war in wars)
		{
			counter++;
			sb.AppendLine($"War {counter} issued by {war}");
		}

		return sb.ToString();
	}
}

