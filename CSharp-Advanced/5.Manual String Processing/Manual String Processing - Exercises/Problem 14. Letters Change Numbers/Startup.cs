using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_14.Letters_Change_Numbers
{
	class Startup
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine().Split(new char[] { ' ', '\t', '\r' }, StringSplitOptions.RemoveEmptyEntries);
			var totalSum = 0d;
			var lower = new Dictionary<char, int>()
			{
				{'a',1},
				{'b',2},
				{'c',3},
				{'d',4},
				{'e',5},
				{'f',6},
				{'g',7},
				{'h',8},
				{'i',9},
				{'j',10},
				{'k',11},
				{'l',12},
				{'m',13},
				{'n',14},
				{'o',15},
				{'p',16},
				{'q',17},
				{'r',18},
				{'s',19},
				{'t',20},
				{'u',21},
				{'v',22},
				{'w',23},
				{'x',24},
				{'y',25},
				{'z',26}
			};
			var upper = new Dictionary<char, int>()
				{
					{'A',1},
					{'B',2},
					{'C',3},
					{'D',4},
					{'E',5},
					{'F',6},
					{'G',7},
					{'H',8},
					{'I',9},
					{'J',10},
					{'K',11},
					{'L',12},
					{'M',13},
					{'N',14},
					{'O',15},
					{'P',16},
					{'Q',17},
					{'R',18},
					{'S',19},
					{'T',20},
					{'U',21},
					{'V',22},
					{'W',23},
					{'X',24},
					{'Y',25},
					{'Z',26}
				}
				;
			foreach (var word in input)
			{
				var firstChar = word[0];
				var lastChar = word[word.Length - 1];
				var number = word.Substring(1, word.Length - 2);
				var resultedNumber = double.Parse(number);
				var isFirstCharUpper = char.IsUpper(firstChar);
				var isLastCharUpper = char.IsUpper(lastChar);

				if (isFirstCharUpper)
				{
					resultedNumber /= upper[firstChar];
				}
				else
				{
					resultedNumber *= lower[firstChar];
				}
				if (isLastCharUpper)
				{
					resultedNumber -= upper[lastChar];
				}
				else
				{
					resultedNumber += lower[lastChar];
				}
				totalSum += resultedNumber;
			}
			Console.WriteLine($"{totalSum:f2}");
		}
	}
}