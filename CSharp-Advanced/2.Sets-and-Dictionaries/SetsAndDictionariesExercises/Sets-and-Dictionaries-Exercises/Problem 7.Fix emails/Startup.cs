using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Fix_emails
{
	class Startup
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			var dictionary = new Dictionary<string,string>();
			while (input != "stop")
			{
				if (!dictionary.ContainsKey(input))
				{
					var email = Console.ReadLine();
					if (!email.EndsWith("us") && !email.EndsWith("us"))
					{
						dictionary.Add(input, email);
					}
				}
				input = Console.ReadLine();
			}
			foreach (var name in dictionary)
			{
				Console.WriteLine($"{name.Key} -> {name.Value}");
			}
		}
	}
}
