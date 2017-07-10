using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_05.Mordor_Cruelty_Plan.Models
{
	class Gandalf
	{
		public Gandalf()
		{
			this.Foods = new List<string>();
		}
		private List<string> foods;

		public List<string> Foods
		{
			get { return foods; }
			set { foods = value; }
		}

		private string mood;

		public string Mood
		{
			get { return mood; }
			set { mood = value; }
		}

		private int happiness;

		public int Happiness
		{
			get { return happiness; }
			set { happiness = value; }
		}

		public void CalculateHappiness()
		{
			var dictionary = new Dictionary<string, int>()
			{
				{"cram", 2},
				{"lembas", 3},
				{"apple", 1},
				{"melon", 1},
				{"honeycake", 5},
				{"mushrooms", -10},
			};

			foreach (var food in foods)
			{
				if (dictionary.ContainsKey(food.ToLower()))
				{
					Happiness += dictionary[food.ToLower()];
				}
				else
				{
					this.Happiness -= 1;
				}
			}
		}

		public void CalculateMood()
		{
			if (happiness >= 1 && happiness <= 15)
			{
				Mood = "Happy";
			}
			else if (happiness > 15)
			{
				Mood = "JavaScript";
			}
			else if (happiness >= -5 && happiness<= 0)
			{
				Mood = "Sad";
			}
			else 
			{
				Mood = "Angry";
			}
		}
	}
}
