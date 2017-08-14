using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03BarracksFactory.Contracts;

namespace _03BarracksFactory.Core.Commands
{
	public abstract class Command : IExecutable
	{
		private string[] data;
		private IRepository repository;
		private IUnitFactory unitFactory;

		protected Command(string[] data, IRepository repository, IUnitFactory unitFactory)
		{
			this.Data = data;
			this.Repository = repository;
			this.UnitFactory = unitFactory;
		}

		protected IUnitFactory UnitFactory
		{
			get { return unitFactory; }
			set { unitFactory = value; }
		}

		protected IRepository Repository
		{
			get { return repository; }
			set { repository = value; }
		}

		protected string[] Data
		{
			get { return data; }
			set { data = value; }
		}







		public abstract string Execute();
	}
}
