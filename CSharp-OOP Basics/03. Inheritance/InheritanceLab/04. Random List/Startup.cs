using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Random_List
{
	class Startup
	{
		static void Main(string[] args)
		{
			var randomList = new RandomList();
			randomList.Add("Pesho");
			randomList.Add("Sasho");
			randomList.Add("Gosho");

			Console.WriteLine(randomList.RandomString());
		}
	}
}
