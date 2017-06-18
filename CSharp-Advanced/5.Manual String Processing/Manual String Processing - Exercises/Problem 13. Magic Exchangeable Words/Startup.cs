using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_13.Magic_Exchangeable_Words
{
	class Startup
	{
		static void Main(string[] args)
		{
			string[] inputArray = Console.ReadLine().Trim().Split();
			HashSet<char> firstWord = new HashSet<char>(inputArray[0]);
			HashSet<char> secondWord = new HashSet<char>(inputArray[1]);
			Console.WriteLine((firstWord.Count == secondWord.Count) ? "true" : "false");
		}
	}
}
