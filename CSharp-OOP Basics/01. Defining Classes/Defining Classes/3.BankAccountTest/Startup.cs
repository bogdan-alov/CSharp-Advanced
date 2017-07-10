using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.BankAccountTest
{
	class Startup
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			var list = new HashSet<BankAccount>();
			while (input != "End")
			{
				var array = input.Split(' ');
				if (array[0] == "Create")
				{
					var acc = new BankAccount();
					acc.Id = int.Parse(array[1]);
					if (list.Any(c=> c.Id == int.Parse(array[1])))
					{
						Console.WriteLine("Account already exist");
					}
					else
					{
						list.Add(acc);
					}
				}
				else if (array[0] == "Deposit")
				{
					
					if (list.Any(c=> c.Id == int.Parse(array[1])))
					{
						list.FirstOrDefault(c => c.Id == int.Parse(array[1])).Deposit(double.Parse(array[2]));
					}
					else
					{
						Console.WriteLine("Account does not exist");
					}
				}
				else if (array[0] == "Withdraw")
				{
					if (list.Any(c => c.Id == int.Parse(array[1])))
					{
						if (list.FirstOrDefault(c => c.Id == int.Parse(array[1])).Balance < double.Parse(array[2]))
						{
							Console.WriteLine("Insufficient balance");
						}
						else
						{
							list.FirstOrDefault(c => c.Id == int.Parse(array[1])).Withdraw(double.Parse(array[2]));
						}
					}
					else
					{
						Console.WriteLine("Account does not exist");
					}
				}
				else if (array[0] == "Print")
				{
					if (list.Any(c=> c.Id == int.Parse(array[1])))
					{
						var acc = list.FirstOrDefault(c => c.Id == int.Parse(array[1]));
						Console.WriteLine($"Account ID{acc.Id}, balance {acc.Balance:f2}");
					}
					else
					{
						Console.WriteLine("Account does not exist");
					}
				}


				input = Console.ReadLine();
			}
			
		}
	}
}
