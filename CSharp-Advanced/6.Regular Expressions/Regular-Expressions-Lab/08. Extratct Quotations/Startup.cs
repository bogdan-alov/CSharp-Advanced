﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08.Extratct_Quotations
{
	class Startup
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			var pattern = "('|\")(.+?)\\1";
			var regex = new Regex(pattern);
			var matches = regex.Matches(input);
			foreach (Match match in matches)
			{
				Console.WriteLine(match.Groups[2]);
			}

		}
	}
}
