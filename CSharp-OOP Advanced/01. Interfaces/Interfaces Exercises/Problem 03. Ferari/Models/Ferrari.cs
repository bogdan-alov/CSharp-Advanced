using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03.Ferari.Models
{
	class Ferrari : ICar
	{
		public Ferrari( string driver)
		{
			this.Driver = driver;
			this.Model = "488-Spider";
		}
		public string Model { get; private set; }
		public string Driver { get; private set; }
		public string Brakes()
		{
			return "Brakes!";
		}

		public string PushGas()
		{
			return "Zadu6avam sA!";
		}

		public override string ToString()
		{
			return $"{this.Model}/{this.Brakes()}/{this.PushGas()}/{this.Driver}";
		}
	}
}
