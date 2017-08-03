using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01.Card_Suit
{
	class Program
	{
		static void Main(string[] args)
		{
			// Problem 01. and 02.

			//var input = Console.ReadLine();

			//if (input == "Card Suits")
			//{
			//	Console.WriteLine($"{input}:");
			//	foreach (var card in Enum.GetValues(typeof(CardSuits)))
			//	{
			//		Console.WriteLine($"Ordinal value: {(int)card}; Name value: {(CardSuits)card}");
			//	}
			//}
			//else if (input == "Card Ranks")
			//{
			//	Console.WriteLine($"{input}:");
			//	foreach (var cardRank in Enum.GetValues(typeof(CardRanks)))
			//	{
			//		Console.WriteLine($"Ordinal value: {(int)cardRank}; Name value: {(CardRanks)cardRank}");
			//	}
			//}

			//Problems 03. - 05. 

			//var firstCardRank = Console.ReadLine();
			//var firstCardSuit = Console.ReadLine();

			//var secondCardRank = Console.ReadLine();
			//var secondCardSuit = Console.ReadLine();

			//var secondCard = new Card(secondCardRank, secondCardSuit);
			//var firstCard = new Card(firstCardRank, firstCardSuit);
			//if (firstCard.CompareTo(secondCard) == 1)
			//{
			//	Console.WriteLine(firstCard);
			//}
			//else
			//{
			//	Console.WriteLine(secondCard);
			//}

			// Problem 06. 

			//var input = Console.ReadLine();

			//if (input == "Rank")
			//{

			//	var attr = typeof(CardRanks).GetCustomAttributes(
			//		true
			//	);

			//	var type = ((TypeAttribute)attr[0]).Type;
			//	var description = ((TypeAttribute)attr[0]).Description;

			//	Console.WriteLine($"Type = {type}, Description = {description}");

			//}
			//else
			//{
			//	var attr = typeof(CardSuits).GetCustomAttributes(
			//		true
			//	);

			//	var type = ((TypeAttribute)attr[0]).Type;
			//	var description = ((TypeAttribute)attr[0]).Description;

			//	Console.WriteLine($"Type = {type}, Description = {description}");
			//}

			// Problem 07. and 08.


			var listOfCards = new HashSet<Card>();

			var cardRankses = Enum.GetValues(typeof(CardRanks)).Cast<CardRanks>().ToArray();

			var cardSuitses = Enum.GetValues(typeof(CardSuits)).Cast<CardSuits>().ToArray();

			foreach (var cardSuit in cardSuitses)
			{
				foreach (var cardRank in cardRankses)
				{
					listOfCards.Add(new Card(cardRank.ToString(), cardSuit.ToString()));
				}
			}
			var player1 = Console.ReadLine();
			var player2 = Console.ReadLine();
			
			var cardsP1 = new List<Card>();
			var cardsP2 = new List<Card>();

			while (cardsP1.Count != 5)
			{
				var card = Console.ReadLine();

				if (cardsP1.FirstOrDefault(c=> c.Name == card) != null)
				{
					Console.WriteLine("Card is not in the deck.");
					continue;
				}
				if (listOfCards.FirstOrDefault(c=> c.Name == card) == null)
				{
					Console.WriteLine("No such card exists.");
					continue;
				}

				cardsP1.Add(listOfCards.FirstOrDefault(c=> c.Name == card));

			}
			while (cardsP2.Count != 5)
			{
				var card = Console.ReadLine();

				if (cardsP2.FirstOrDefault(c => c.Name == card) != null || cardsP1.FirstOrDefault(c => c.Name == card) != null)
				{
					Console.WriteLine("Card is not in the deck.");
					continue;
				}
				if (listOfCards.FirstOrDefault(c => c.Name == card) == null)
				{
					Console.WriteLine("No such card exists.");
					continue;
				}

				cardsP2.Add(listOfCards.FirstOrDefault(c => c.Name == card));
			}
			var sum1 = cardsP1.Sum(c=> c.CalculatePower());
			var sum2 = cardsP2.Sum(c => c.CalculatePower());

			if (sum1 > sum2)
			{
				Console.WriteLine($"{player1} wins with {cardsP1.OrderByDescending(c=> c.CalculatePower()).FirstOrDefault().Name}.");
			}
			else
			{
				Console.WriteLine($"{player2} wins with {cardsP2.OrderByDescending(c => c.CalculatePower()).FirstOrDefault().Name}.");
			}
		}
	}
}
