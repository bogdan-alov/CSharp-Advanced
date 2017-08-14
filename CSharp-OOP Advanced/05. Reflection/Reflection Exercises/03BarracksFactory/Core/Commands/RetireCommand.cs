using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03BarracksFactory.Contracts;

namespace _03BarracksFactory.Core.Commands
{
	class RetireCommand : Command
	{
		public RetireCommand(string[] data, IRepository repository, IUnitFactory unitFactory) : base(data, repository, unitFactory)
		{
		}

		public override string Execute()
		{
			var unitToRemove = this.Data[1];
			this.Repository.RemoveUnit(unitToRemove);
			return $"{unitToRemove} retired!";

		}
	}
}
