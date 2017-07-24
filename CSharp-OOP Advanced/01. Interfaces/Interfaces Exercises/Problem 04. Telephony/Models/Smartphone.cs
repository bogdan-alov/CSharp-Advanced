using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_04.Telephony.Models
{
	public class Smartphone : ICallable, IBrowseable
	{


		public string Call(string number)
		{

			if (Regex.IsMatch(number, "^\\d+$"))
			{
				return $"Calling... {number}"; 
			}

			return "Invalid number!";


		}

		public string Browse(string site)
		{

			if (Regex.IsMatch(site, "\\d"))
			{
				return "Invalid URL!";
			}
			return $"Browsing: {site}!";

		}
	}
}
