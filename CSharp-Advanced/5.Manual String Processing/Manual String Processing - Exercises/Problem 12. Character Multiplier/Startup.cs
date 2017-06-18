using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterMultiplier
{
	class Startup
	{
		static void Main()
		{
			var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
			string word1 = input[0];
			string word2 = input[1];
			var totalSum = 0;
			var minLen = Math.Min(word1.Length, word2.Length);
			var maxLen = Math.Max(word1.Length, word2.Length);
			for (int i = 0; i < word1.Length; i++)
			{
				totalSum += word1[i] * word2[i];
			}

			string longerInput = word1.Length > word2.Length ? longerInput = word1 : longerInput = word2;
			for (int i = minLen; i < maxLen; i++)
			{
				totalSum += longerInput[i];
			}

			Console.WriteLine(totalSum);

		}
	}
}
