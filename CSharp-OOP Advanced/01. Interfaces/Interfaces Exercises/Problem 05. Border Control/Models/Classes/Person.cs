using Problem_05.Border_Control.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_05.Border_Control.Models
{
	public class Person : IPerson, IIdentifiable, IBirthable, IBuyer
	{
		public Person(string name, int age, string id, string birthDay)
		{
			this.Name = name;
			this.Age = age;
			this.Id = id;
			this.Birthday = birthDay;
			this.Food = 0;
		}
		public int Age { get; }
		public string Name { get; }
		public string Id { get; }
		public string Birthday { get; }
		public int Food { get; set; }
		public void BuyFood()
		{
			this.Food += 10;
		}
	}
}
