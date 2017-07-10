using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CubicMessages
{
	class Startup
	{
		static void Main(string[] args)
		{


			var message = Console.ReadLine();
			var lenght = int.Parse(Console.ReadLine());
			var pattern = "^(\\d+)([A-Za-z]+)([^a-zA-Z ]*?)$";
			while (true)
			{
				

				var match = Regex.Match(message, pattern);
				if (match.Success)
				{
					var realMessage = match.Groups[2].Value;
					if (realMessage.Length == lenght)
					{
						var firstIndexes = match.Groups[1].Value;
						var secondIndexes = match.Groups[3].Value;
						var sb = new StringBuilder();
						sb.Append($"{realMessage} == ");
						var indexes = Regex.Replace(firstIndexes + secondIndexes, "\\D*", String.Empty);
						foreach (var index in indexes)
						{
							var number = int.Parse(index.ToString());
							if (number >= 0 && number < realMessage.Length)
							{
								sb.Append(realMessage[number]);
							
							}
							else
							{
								sb.Append(" ");
							}
						}
						//foreach (var index in firstIndexes)
						//{
						//	var number = (int)Char.GetNumericValue(index);

						//	if (number < 0 || number > realMessage.Length - 1)
						//	{
						//		sb.Append(" ");
						//	}
						//	else
						//	{
						//		sb.Append(realMessage[number]);
						//	}


						//}
						//foreach (var index in secondIndexes)
						//{
						//	var number = -1;
						//	var IsNumber = int.TryParse(index.ToString(), out number);

						//	if (!IsNumber || number < 0 || number >= realMessage.Length)
						//	{
						//		sb.Append(" ");
						//	}
						//	else
						//	{
						//		sb.Append(realMessage[number]);
						//	}



						//}

						Console.WriteLine(sb);
					}
				}
					

				message = Console.ReadLine();
				if (message == "Over!")
				{
					break;

				}
				lenght = int.Parse(Console.ReadLine());

			}
		}
	}
}
