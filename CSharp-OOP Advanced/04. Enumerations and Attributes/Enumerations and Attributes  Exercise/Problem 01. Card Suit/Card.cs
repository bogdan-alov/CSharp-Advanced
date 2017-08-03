using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01.Card_Suit
{
	class Card: IComparable<Card>
	{
		public Card(string cardRank, string cardSuit)
		{
			this.CardSuit = (CardSuits) Enum.Parse(typeof(CardSuits), cardSuit);
			this.CardRank = (CardRanks) Enum.Parse(typeof(CardRanks), cardRank);
		}
		public CardSuits CardSuit { get; private set; }

		public CardRanks CardRank { get; private set; }

		public string Name
		{
			get { return $"{this.CardRank} of {this.CardSuit}"; }
		}

		public int CalculatePower()
		{
			return (int) this.CardRank + (int) this.CardSuit;
		}

		public override string ToString()
		{
			return $"Card name: {this.CardRank} of {this.CardSuit}; Card power: {this.CalculatePower()}";
		}

		public int CompareTo(Card other)
		{
			return this.CalculatePower().CompareTo(other.CalculatePower());
		}
	}
}
