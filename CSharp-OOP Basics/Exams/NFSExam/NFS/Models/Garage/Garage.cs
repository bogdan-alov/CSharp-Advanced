
using System.Collections.Generic;

class Garage
{
	public Garage()
	{
		this.ParkedCars = new List<Car>();
	}
	private List<Car> parkedCars;

	public List<Car> ParkedCars
	{
		get { return parkedCars; }
		set { parkedCars = value; }
	}

}

