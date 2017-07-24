using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_05.Border_Control.Models.Interfaces
{
	public interface IBuyer
	{
		void BuyFood();
		string Name { get; }
		int Food { get; }
	}
}
