
using System;

public class Engine
{
	public void Run()
	{
		var input = "";
		var nationsBuilder = new NationsBuilder();
		while ((input = Console.ReadLine()) != "Quit")
		{
			var cmdArgs = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			if (cmdArgs[0] == "Bender")
			{
				nationsBuilder.AssignBender(cmdArgs[1], cmdArgs[2], int.Parse(cmdArgs[3]), double.Parse(cmdArgs[4]));
			}
			else if (cmdArgs[0] == "War")
			{
				nationsBuilder.IssueWar(cmdArgs[1]);
			}
			else if (cmdArgs[0] == "Status")
			{
				Console.Write(nationsBuilder.GetStatus(cmdArgs[1]));
			}
			else if (cmdArgs[0] == "Monument")
			{
				nationsBuilder.AssignMonument(cmdArgs[1], cmdArgs[2], int.Parse(cmdArgs[3]));
			}
		}
		Console.Write(nationsBuilder.GetWarsRecord());
	}
}

