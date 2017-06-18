using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07.Valid_Time
{
	class Startup
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			var pattern = "^[01][0-9][:][0-5][0-9][:][0-5][0-9]\\s(A|P)M$";
			while (input != "END")
			{

				var regex = new Regex(pattern);
				var match = regex.Match(input);
				if (match.Success)
				{
					if (IsValid(match))
					{
						Console.WriteLine("valid");
					}
					else
					{
						Console.WriteLine("invalid");
					}
				}
				else
				{
					Console.WriteLine("invalid");
				}
				
				input = Console.ReadLine();
			}
		}

		private static bool IsValid(Match match)
		{
			
				var date = match.ToString();
				if (date.Contains("AM"))
				{
					var d1 = int.Parse(date.Substring(0, 2));
					if (d1 > 12)
					{
						return false;
					}
					return true;
				}
				if (date.Contains("PM"))
				{
					var d1 = int.Parse(date.Substring(0, 2));
					if (d1 > 11)
					{
						return false;
					}
					return true;
				}
			

			return false;
		}
	}
}
