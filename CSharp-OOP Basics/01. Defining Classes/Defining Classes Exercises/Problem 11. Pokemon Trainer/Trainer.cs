﻿using System;
using System.Collections.Generic;


namespace Problem_11.Pokemon_Trainer
{
	class Trainer
	{
		public Trainer()
		{
			this.Pokemons = new List<Pokemon>();
		}
		public string Name { get; set; }

		public int NumberOfBadges { get; set; }

		public List<Pokemon> Pokemons { get; set; }

		public override string ToString()
		{
			return $"{Name} {NumberOfBadges} {Pokemons.Count}";
		}
	}
}
