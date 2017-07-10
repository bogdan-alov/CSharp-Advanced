using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Methods
{
	class Startup
	{
		static void Main(string[] args)
		{
			var acc = new BankAccount();

			acc.Deposit(10);
			acc.Withdraw(5);

			Console.WriteLine(acc.Balance);
		}
	}
}
