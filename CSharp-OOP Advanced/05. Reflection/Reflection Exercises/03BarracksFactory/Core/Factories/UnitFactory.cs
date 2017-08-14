using _03BarracksFactory.Models.Units;

namespace _03BarracksFactory.Core.Factories
{
    using System;
    using Contracts;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
	        if (unitType == "Swordsman")
	        {
		        return new Swordsman();
	        }

	        if (unitType == "Archer")
	        {
		        return new Archer(); 
	        }
	
	        if (unitType == "Pikeman")
	        {
		        return new Pikeman();
	        }

	        if (unitType == "Horseman")
	        {
		        return new Horseman();
	        }

	        if (unitType == "Gunner")
	        {
		        return new Gunner();
	        }
	        return null;
        }
    }
}
