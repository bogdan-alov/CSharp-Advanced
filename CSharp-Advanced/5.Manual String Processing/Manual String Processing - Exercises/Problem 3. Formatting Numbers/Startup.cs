using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Formatting_Numbers
{
	class Startup
	{
		static void Main(string[] args)
		{
			
			var input = Console.ReadLine().Split(new []{' ', '\n', '\t'}, StringSplitOptions.RemoveEmptyEntries).ToArray();
			var a = int.Parse(input[0]);
			var b = decimal.Parse(input[1]);
			var c = decimal.Parse(input[2]);
			var convertAToHex = a.ToString("X");
			var convertAToBinary = Convert.ToString(a, 2);
			if (convertAToBinary.Length < 10)
			{
				convertAToBinary=convertAToBinary.PadLeft(10,'0');
			}
			if (convertAToBinary.Length > 10)
			{
				convertAToBinary = convertAToBinary.Substring(0, 10);
			}
			Console.WriteLine("|{0,-10}|{1,10}|{2,10:f2}|{3,-10:f3}|", convertAToHex, convertAToBinary, b,c);
		}
	}
}
