
using System;
using System.Linq;

public class Engine
{
	public void Run()
	{
		var input = "";
		var draftManager = new DraftManager();
		while ((input = Console.ReadLine()) != "Shutdown")
		{
			var cmdArgs = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
			if (cmdArgs[0] == "RegisterHarvester")
			{
				Console.WriteLine(draftManager.RegisterHarvester(cmdArgs.Skip(1).ToList()));
			}
			else if (cmdArgs[0] == "RegisterProvider")
			{
				Console.WriteLine(draftManager.RegisterProvider(cmdArgs.Skip(1).ToList()));
			}
			else if (cmdArgs[0] == "Day")
			{
				Console.Write(draftManager.Day());
				
			}
			else if (cmdArgs[0] == "Check")
			{
				
				int numLines = draftManager.Check(cmdArgs.Skip(1).ToList()).Split('\n').Length;
				if (numLines == 1)
				{
					Console.WriteLine(draftManager.Check(cmdArgs.Skip(1).ToList()));
				}
				else
				{
					Console.Write(draftManager.Check(cmdArgs.Skip(1).ToList()));
				}
			}
			else if (cmdArgs[0] == "Mode")
			{
				Console.WriteLine(draftManager.Mode(cmdArgs.Skip(1).ToList()));
			}
		}
		Console.Write(draftManager.ShutDown());
	}
}

