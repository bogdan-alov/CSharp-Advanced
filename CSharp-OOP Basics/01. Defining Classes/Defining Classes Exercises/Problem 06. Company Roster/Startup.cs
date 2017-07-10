using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_06.Company_Roster
{
	class Startup
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var dictionary = new Dictionary<string, List<Employee>>();
			for (int i = 0; i < n; i++)
			{
				var input = Console.ReadLine().Split(' ');
				var employee = new Employee();
				employee.name = input[0];
				employee.salary = double.Parse(input[1]);
				employee.position = input[2];
				employee.department = input[3];
				if(input.Length == 5)
				{
					int age; 
					if (int.TryParse(input[4], out age))
					{
						employee.age = age;
					}
					else
					{
						employee.email = input[4];
					}
				}
				if (input.Length == 6)
				{
					employee.email = input[4];
					employee.age = int.Parse(input[5]);
				}
				if (!dictionary.ContainsKey(employee.department))
				{
					dictionary.Add(employee.department, new List<Employee>());
					dictionary[employee.department].Add(employee);
				}
				else
				{
					dictionary[employee.department].Add(employee);
				}
			}

			var richest = dictionary.OrderByDescending(c => c.Value.Select(x => x.salary).Sum()).FirstOrDefault();
			Console.WriteLine($"Highest Average Salary: {richest.Key}");
			foreach (var employee in richest.Value.OrderByDescending(c=> c.salary))
			{
				Console.WriteLine($"{employee.name} {employee.salary:f2} {employee.email} {employee.age}");
			}
		}

		
	}
}
