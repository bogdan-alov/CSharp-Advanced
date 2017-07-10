using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_05.Mordor_Cruelty_Plan.Models;

namespace Problem_05.Mordor_Cruelty_Plan
{
	class Startup
	{
		static void Main(string[] args)
		{
			var gandalf = new Gandalf();
			var input = Console.ReadLine().Split();
			foreach (var s in input)
			{
				gandalf.Foods.Add(s);
			}
			gandalf.CalculateHappiness();
			gandalf.CalculateMood();
			Console.WriteLine(gandalf.Happiness);
			Console.WriteLine(gandalf.Mood);
		}
	}
}
