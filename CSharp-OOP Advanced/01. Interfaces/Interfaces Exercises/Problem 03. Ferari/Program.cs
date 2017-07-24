﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_03.Ferari.Models;

namespace Problem_03.Ferari
{
	class Program
	{
		static void Main(string[] args)
		{
			var driver = Console.ReadLine();
			var ferrari = new Ferrari(driver);
			Console.WriteLine(ferrari);

			string ferrariName = typeof(Ferrari).Name;
			string iCarInterfaceName = typeof(ICar).Name;

			bool isCreated = typeof(ICar).IsInterface;
			if (!isCreated)
			{
				throw new Exception("No interface ICar was created");
			}

		}
	}
}
