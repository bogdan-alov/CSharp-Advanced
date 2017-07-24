using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_05.Border_Control.Models
{
	public class Pet : IPet, IBirthable
	{
		public Pet(string name, string birthDay)
		{
			this.Name = name;
			this.Birthday = birthDay;
		}
		public string Birthday { get; }
		public string Name { get; }
	}
}
