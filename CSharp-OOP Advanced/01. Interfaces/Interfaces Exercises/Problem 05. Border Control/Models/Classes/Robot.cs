using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_05.Border_Control.Models
{
	public class Robot : IIdentifiable, IRobot
	{
		public Robot(string name, string id)
		{
			this.Id = id;
			this.Name = name;
		}
		public string Id { get;}
		public string Name { get;  }

		
	}
}
