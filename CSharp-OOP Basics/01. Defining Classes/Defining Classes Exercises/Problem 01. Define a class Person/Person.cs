using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01.Define_a_class_Person
{
	public class Person
	{
		public Person()
		{
			this.name = "No name";
			this.age = 1;
			
		}

		public Person(int age) : this()
		{
			this.age = age;
		}

		public Person(string name, int age) : this()
		{
			this.name = name;
			this.age = age;
		}
		public string name;
		public int age;



	}
}
