using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03.Tuple
{
	class Program
	{
		static void Main(string[] args)
		{
			var firstInput = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
			var name = firstInput[0] + " " + firstInput[1];
			var neighborhood = firstInput[2];
			var city = firstInput[3];
			Tuple<string, string, string> firstTuple = new Tuple<string, string, string>(name,neighborhood ,city);

			var secondInput = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
			var user = secondInput[0];
			var litesOfBeer = int.Parse(secondInput[1]);
			var status = secondInput[2];
			var IsDrunk = false;
			if (status == "drunk") IsDrunk = true;
	
			Tuple<string,int, bool> secondTuple = new Tuple<string, int, bool>(user, litesOfBeer, IsDrunk);


			var thirdInput = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			var person = thirdInput[0];
			var accountBalance = double.Parse(thirdInput[1]);
			var bankName = thirdInput[2];
			Tuple<string, double, string> thirdTuple = new Tuple<string, double, string>(person,accountBalance ,bankName);

			Console.WriteLine(firstTuple);
			Console.WriteLine(secondTuple);
			Console.WriteLine(thirdTuple);

		}
	}
}
