using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03.Oldest_Family_Member
{
	class Family
	{
		public Family()
		{
			this.people = new List<Person>();
		}
		public List<Person> people;


		public void AddMember(Person person)
		{
			this.people.Add(person);
		}


		public Person GetOldestMember()
		{
			return people.OrderByDescending(c => c.age).FirstOrDefault();
		}
	}
}
