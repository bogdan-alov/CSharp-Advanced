using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_05.Border_Control.Models.Interfaces;

namespace Problem_05.Border_Control.Models.Classes
{
	public class Rebel : IBuyer
	{
		public Rebel(string name, int age, string group)
		{
			this.Name = name;
			this.Age = age;
			this.Group = group;
			this.Food = 0;
		}
		private string name;
		private int age;
		private string group;
		private int food;

		public int Food
		{
			get { return food; }
			set { food = value; }
		}

		public string Group
		{
			get { return group; }
			set { group = value; }
		}

		public int Age
		{
			get { return age; }
			set { age = value; }
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public void BuyFood()
		{
			this.Food += 5;
		}
	}
}
