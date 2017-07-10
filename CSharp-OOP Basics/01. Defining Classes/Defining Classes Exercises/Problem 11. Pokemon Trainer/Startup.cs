using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11.Pokemon_Trainer
{
	class Startup
	{
		static void Main(string[] args)
		{
			var input = "";
			var trainers = new List<Trainer>();
			while ((input = Console.ReadLine()) != "Tournament")
			{
				var array = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
				var trainer = new Trainer();
				trainer.Name = array[0];
				var pokemon = new Pokemon();
				pokemon.Name = array[1];
				pokemon.Element = array[2];
				pokemon.Health = int.Parse(array[3]);
				trainer.Pokemons.Add(pokemon);
				if (!trainers.Any(c => c.Name.Equals(trainer.Name)))
				{
					trainers.Add(trainer);
				}
				else
				{
					trainers.FirstOrDefault(c => c.Name == trainer.Name).Pokemons.Add(pokemon);
				}
			}

			while ((input = Console.ReadLine()) != "End")
			{
				foreach (var trainer in trainers)
				{
					if (trainer.Pokemons.Any(c=> c.Element.Equals(input)))
					{
						trainer.NumberOfBadges++;
					}
					else
					{
						for (int i = 0; i < trainer.Pokemons.Count; i++)
						{
							trainer.Pokemons[i].Health -= 10;
							if (trainer.Pokemons[i].Health <= 0)
							{
								trainer.Pokemons.RemoveAt(i);
							}
						}
					}
				}
			}
			for (int i = 0; i < trainers.Count; i++)
			{
				if (trainers[i].Pokemons.Any(c => c.Health <= 0))
				{
					trainers[i].Pokemons.RemoveAll(c => c.Health <= 0);
				}
			}

			foreach (var trainer in trainers.OrderByDescending(c => c.NumberOfBadges))
			{
				Console.WriteLine(trainer);
			}
			Console.WriteLine();
		}

	}
}
