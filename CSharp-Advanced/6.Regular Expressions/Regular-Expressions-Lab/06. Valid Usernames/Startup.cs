using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Valid_Usernames
{
	class Startup
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			var pattern = "^[A-Za-z0-9_-]{3,16}$";
			while (input != "END")
			{

				var regex = new Regex(pattern);
				var match = regex.Match(input);
				if (match.Success)
				{
					Console.WriteLine("valid");
				}
				if (!match.Success)
				{
					Console.WriteLine("invalid");
				}

				input = Console.ReadLine();
			}
		}
	}
}
