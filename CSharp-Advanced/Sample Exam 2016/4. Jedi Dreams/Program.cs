using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4.Jedi_Dreams
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());


			var methods = new List<Method>();

			var methodNamePattern = @"static\s\w+\s([A-Za-z]+)\(";
			var invokesPattern = @"([a-zA-Z]*[A-Z]+[a-zA-Z]*)\s*\(";

			var lastMethod = string.Empty;

			for (int i = 0; i < n; i++)
			{
				var input = Console.ReadLine();

				if (Regex.IsMatch(input, methodNamePattern))
				{
					var methodName = Regex.Match(input, methodNamePattern).Groups[1].Value;

					if (!methods.Any(c=> c.Name == methodName))
					{
						methods.Add(new Method(methodName));
					}
					lastMethod = methodName;
				}
				else if (Regex.IsMatch(input, invokesPattern))
				{
					var matches = Regex.Matches(input, invokesPattern);

					foreach (Match match in matches)
					{
						methods.FirstOrDefault(c => c.Name ==lastMethod ).Invokes.Add(match.Groups[1].Value);
					}
				}



			}

			foreach (var method in methods.OrderByDescending(c=> c.Invokes.Count).ThenBy(c=> c.Name))
			{
				if (method.Invokes.Count == 0)
				{
					Console.WriteLine($"{method.Name} -> None");
				}
				else
				{
					Console.WriteLine($"{method.Name} -> {method.Invokes.Count} -> {string.Join(", ", method.Invokes.OrderBy(c => c))}");
				}
			}
		}
	}

	class Method
	{
		public Method(string name)
		{
			this.Name = name;
			this.Invokes = new List<string>();
		}
		public string Name { get; set; }
		public List<string> Invokes { get; set; }
	}
}