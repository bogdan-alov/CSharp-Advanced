
using System.Collections.Generic;
using System.Text;

abstract class Race
{
	public Race(int length, string route, int prizePool)
	{
		this.Length = length;
		this.Route = route;
		this.PrizePool = prizePool;
		this.Participands = new List<Car>();
	}
	private int length;
	private string route;
	private int prizePool;
	private List<Car> participants;

	public List<Car> Participands
	{
		get { return participants; }
		set { participants = value; }
	}

	public int PrizePool
	{
		get { return prizePool; }
		set { prizePool = value; }
	}

	public string Route
	{
		get { return route; }
		set { route = value; }
	}

	public int Length
	{
		get { return length; }
		set { length = value; }
	}

	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.AppendLine($"{Route} - {Length}");
		return sb.ToString();
	}
}

