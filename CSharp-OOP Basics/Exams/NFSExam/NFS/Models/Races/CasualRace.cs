
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class CasualRace : Race
{
	public CasualRace(int length, string route, int prizePool) : base(length, route, prizePool)
	{
	}

	public override string ToString()
	{
		var sb = new StringBuilder(base.ToString());
		var winners = this.Participands
			.Select(c => new
			{
				Brand = c.Brand,
				Model = c.Model,
				PerformancePoints = (c.HorsePower / c.Acceleration) + (c.Suspension + c.Durability)
			}).OrderByDescending(c => c.PerformancePoints).ToList().Take(3);
		var counter = 0;
		foreach (var winner in winners)
		{
			counter++;
			if (counter == 1)
			{
				sb.AppendLine($"1. {winner.Brand} {winner.Model} {winner.PerformancePoints}PP - ${this.PrizePool / 2}");
			}
			else if (counter == 2)
			{
				sb.AppendLine($"2. {winner.Brand} {winner.Model} {winner.PerformancePoints}PP - ${(this.PrizePool * 30) / 100}");
			}
			else if (counter == 3)
			{
				sb.AppendLine($"3. {winner.Brand} {winner.Model} {winner.PerformancePoints}PP - ${(this.PrizePool * 20) / 100}");
				break;
			}
		}
		return sb.ToString();
	}
}
