
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

public class CarManager
{
	private Dictionary<int, Car> cars;
	private Dictionary<int, Race> races;
	private Garage garage;

	public CarManager()
	{
		this.cars = new Dictionary<int, Car>();
		this.races = new Dictionary<int, Race>();
		this.garage = new Garage();
	}
	public void Register(int id, string type, string brand, string model, int yearOfProduction, int horsePower,
		int acceleration, int suspension, int durability)
	{

		if (type == "Performance")
		{
			this.cars.Add(id, new PerformanceCar(brand, model, yearOfProduction, horsePower, acceleration, suspension, durability));
		}
		else
		{
			this.cars.Add(id, new ShowCar(brand, model, yearOfProduction, horsePower, acceleration, suspension, durability));
		}

	}

	public string Check(int id)
	{
		var car = cars.FirstOrDefault(c => c.Key == id).Value;
		return car.ToString();
	}

	public void Open(int id, string type, int length, string route, int prizePool)
	{

		if (type == "Casual")
		{
			races.Add(id, new CasualRace(length, route, prizePool));
		}
		else if (type == "Drag")
		{
			races.Add(id, new DragRace(length, route, prizePool));
		}
		else if (type == "Drift")
		{
			races.Add(id, new DriftRace(length, route, prizePool));
		}

	}

	public void Participate(int carId, int raceId)
	{
		var car = cars.FirstOrDefault(c => c.Key == carId).Value;
		if (!garage.ParkedCars.Contains(car))
		{
			races[raceId].Participands.Add(car);
		}

	}

	public string Start(int id)
	{
		var race = races.FirstOrDefault(c => c.Key == id).Value;
		if (race.Participands.Count > 0)
		{
			races.Remove(id);
			return race.ToString();
		}

		return "Cannot start the race with zero participants.\n";
	}

	public void Park(int id)
	{
		var car = cars.FirstOrDefault(c => c.Key == id).Value;
		if (!races.Any(c => c.Value.Participands.Contains(car)))
		{
			this.garage.ParkedCars.Add(car);
		}
	}

	public void Unpark(int id)
	{
		var car = cars.FirstOrDefault(c => c.Key == id).Value;
		if (garage.ParkedCars.Contains(car))
		{
			garage.ParkedCars.Remove(car);
		}
	}

	public void Tune(int tuneIndex, string addOn)
	{
		if (garage.ParkedCars.Count > 0)
		{
			for (int i = 0; i < garage.ParkedCars.Count; i++)
			{
				garage.ParkedCars[i].Tune(tuneIndex, addOn);
			}
		}
	}
}

