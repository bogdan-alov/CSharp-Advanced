
using System.Collections.Generic;

public class HarvestFactory
{
	public static Harvester Register(List<string> arguments)
	{


		return new HammerHarvester("", 12,12);
	}


	public static Harvester Check(List<string> arguments)
	{
		
		var harvester = new HammerHarvester("",12,12);
		return harvester;
	}
}

