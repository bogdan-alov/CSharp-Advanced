
using System;

public class Engine
{
	public void Run()
	{
		var input = "";
		var carManager = new CarManager();
		while ((input = Console.ReadLine()) != "Cops Are Here")
		{
			var cmdArgs = input.Split(' ');;
			ExcuteCommand(cmdArgs, carManager);
		}
	}

	private void ExcuteCommand(string[] cmdArgs, CarManager carManager)
	{
		
		if (cmdArgs[0] == "register")
		{
			carManager.Register(int.Parse(cmdArgs[1]), cmdArgs[2], cmdArgs[3], cmdArgs[4], int.Parse(cmdArgs[5]), int.Parse(cmdArgs[6]), int.Parse(cmdArgs[7]), int.Parse(cmdArgs[8]), int.Parse(cmdArgs[9]));
		}
		else if (cmdArgs[0] == "check")
		{
			Console.WriteLine(carManager.Check(int.Parse(cmdArgs[1])));
		}
		else if (cmdArgs[0] == "open")
		{
			carManager.Open(int.Parse(cmdArgs[1]), cmdArgs[2], int.Parse(cmdArgs[3]), cmdArgs[4], int.Parse(cmdArgs[5]));
		}
		else if (cmdArgs[0] == "participate")
		{
			carManager.Participate(int.Parse(cmdArgs[1]), int.Parse(cmdArgs[2]));
		}
		else if (cmdArgs[0] == "start")
		{
			Console.Write(carManager.Start(int.Parse(cmdArgs[1])));
		}
		else if (cmdArgs[0] == "park")
		{
			carManager.Park(int.Parse(cmdArgs[1]));
		}
		else if (cmdArgs[0] == "unpark")
		{
			carManager.Unpark(int.Parse(cmdArgs[1]));
		}
		else if (cmdArgs[0] == "tune")
		{
			carManager.Tune(int.Parse(cmdArgs[1]), cmdArgs[2]);
		}
	}
}

