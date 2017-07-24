using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03.Ferari.Models
{
	interface ICar
	{
		string Model { get; }
		string Driver { get; }
		string Brakes();
		string PushGas();
	}
}
