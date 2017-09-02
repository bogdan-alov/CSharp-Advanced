using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _3.Number_Wars
{
	class Program
	{
		static void Main(string[] args)
		{
			var hand1 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
			var hand2 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

			var firstPlayer = new Queue<string>(hand1);
			var secondPlayer = new Queue<string>(hand2);


			var sum1 = 0;
			var sum2 = 0;
			var war = new List<string>();
			var turns = 0;
			while (turns < 1000000 && firstPlayer.Count > 0 && secondPlayer.Count > 0)
			{
				if (firstPlayer.Count == 0 || secondPlayer.Count == 0)
				{
					break;
				}
				var number1 = int.Parse(firstPlayer.Peek().Substring(0, firstPlayer.Peek().Length - 1));
				var number2 = int.Parse(secondPlayer.Peek().Substring(0, secondPlayer.Peek().Length - 1));


				if (number1 > number2)
				{
					firstPlayer.Enqueue(firstPlayer.Dequeue());
					firstPlayer.Enqueue(secondPlayer.Dequeue());

				}
				else if (number1 < number2)
				{
					secondPlayer.Enqueue(secondPlayer.Dequeue());
					secondPlayer.Enqueue(firstPlayer.Dequeue());
				}
				else
				{
					war.Add(firstPlayer.Dequeue());
					war.Add(secondPlayer.Dequeue());

					while (true)
					{
						if (firstPlayer.Count < 3 && secondPlayer.Count < 3)
						{
							break;
						}
						for (int i = 0; i < 3; i++)
						{
							char color1 = firstPlayer.Peek().ToLower()[firstPlayer.Peek().Length - 1];
							char color2 = secondPlayer.Peek().ToLower()[secondPlayer.Peek().Length - 1];
							var numberFirst = color1 - 96;
							var numberSecond = color2 - 96;
							sum1 += numberFirst;
							sum2 += numberSecond;
							war.Add(firstPlayer.Dequeue());
							war.Add(secondPlayer.Dequeue());
						}

						if (sum1 > sum2)
						{
							var res = war.Select(c => new {Number = int.Parse(c.Substring(0, c.Length - 1)), Letter = Convert.ToInt32(Char.ToLower(c[c.Length - 1]))}).OrderByDescending(c=> c.Number).ThenByDescending(c=> c.Letter).Select(c=> c.Number.ToString() + (char)c.Letter).ToList();
							firstPlayer = new Queue<string>(res);
							break;
						}
						if (sum1 < sum2)
						{
							var res = war.Select(c => new { Number = int.Parse(c.Substring(0, c.Length - 1)), Letter = Convert.ToInt32(Char.ToLower(c[c.Length - 1])) }).OrderByDescending(c => c.Number).ThenByDescending(c => c.Letter).Select(c => c.Number.ToString() + (char)c.Letter).ToList();
							secondPlayer = new Queue<string>(res);
							break;
						}
					}
					turns++;
					break;
				}
				turns++;
			}

			if (firstPlayer.Count == 0 && secondPlayer.Count == 0)
			{
				Console.WriteLine($"Draw after {turns} turns");
			}
			else
			{
				if (firstPlayer.Count > 0)
				{
					Console.WriteLine($"First player wins after {turns} turns");
				}
				else if (secondPlayer.Count > 0)
				{
					Console.WriteLine($"Second player wins after {turns} turns");
				}
			}

		}

	}
}
