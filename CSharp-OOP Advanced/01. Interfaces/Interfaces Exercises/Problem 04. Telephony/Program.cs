using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_04.Telephony.Models;

namespace Problem_04.Telephony
{
	class Program
	{
		static void Main(string[] args)
		{
			var numbers = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
			var sites = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

			var smartPhone = new Smartphone();
			foreach (var number in numbers)
			{
				Console.WriteLine(smartPhone.Call(number));
			}

			foreach (var site in sites)
			{
				Console.WriteLine(smartPhone.Browse(site));
			}
		}
	}
}
