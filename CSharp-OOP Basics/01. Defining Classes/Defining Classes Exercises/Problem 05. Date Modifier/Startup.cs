using System;
namespace Problem_05.Date_Modifier
{
	class Startup
	{
		static void Main(string[] args)
		{
			var first = Console.ReadLine().Split(' ');

			var second = Console.ReadLine().Split(' ');

			var firstDate =  DateTime.ParseExact($"{first[0]}-{first[1]}-{first[2]}", "yyyy-MM-dd",
				System.Globalization.CultureInfo.InvariantCulture);

			var secondDate = DateTime.ParseExact($"{second[0]}-{second[1]}-{second[2]}", "yyyy-MM-dd",
				System.Globalization.CultureInfo.InvariantCulture);

			var dateModifier = new DateModifier(firstDate, secondDate);


			Console.WriteLine(dateModifier.Difference());

		}
	}
}
