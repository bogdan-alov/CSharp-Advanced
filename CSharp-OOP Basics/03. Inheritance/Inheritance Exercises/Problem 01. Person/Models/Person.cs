using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01.Person.Models
{
	public class Person
	{

		public Person(string name, int age)
		{
			this.Name = name;
			this.Age = age;
		}
		private string name;
		private int age;

		public string Name
		{
			get { return this.name; }
			set
			{
				if (value.Length < 3)
				{
					throw new Exception("Name's length should not be less than 3 symbols!");
				}
				this.name = value;
			}
		}

		public virtual int Age
		{
			get { return this.age; }
			set
			{
				if (value < 0)
				{
					throw new Exception("Age must be positive!");
				}
				this.age = value;
			}
		}
	}
}
