using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_06.Animals
{
	class Animal
	{

		public Animal(string name, int age, string gender)
		{
			Name = name;
			Age = age;
			Gender = gender;
		}
		private int age;

		public int Age
		{
			get { return age; }
			set
			{
				if (value < 0)
				{
					throw new Exception("Invalid input!");
				}
				age = value;
			}
		}

		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private string gender;

		public string Gender
		{
			get { return gender; }
			set { gender = value; }
		}


		public virtual string ProduceSound()
		{

			return "";
		}
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.AppendLine($"{this.GetType().Name}");
			sb.AppendLine($"{this.Name} {this.Age} {this.Gender}");
			sb.Append(ProduceSound());

			return sb.ToString();
		}
	}
}
