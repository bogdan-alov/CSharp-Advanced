using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.BankAccountTest
{
	class BankAccount
	{
		private int id;
		private double balance;

		public int Id
		{
			get { return this.id; }
			set { this.id = value; }
		}

		public double Balance
		{
			get { return this.balance; }
			set { this.balance = value; }
		}

		public void Deposit(double amount)
		{
			balance += amount;
		}


		public void Withdraw(double amount)
		{
			balance -= amount;
		}
	}
}
