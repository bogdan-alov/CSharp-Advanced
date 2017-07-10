using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.NMS
{
	class Startup
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			var sb2 = new StringBuilder();
			while (input != "---NMS SEND---")
			{
				sb2.Append(input);
				input = Console.ReadLine();
			}

			var delimiter = Console.ReadLine();
			var sb= new StringBuilder();
			
			for (int i = 0; i < sb2.Length; i++)
			{
				if (i == sb2.Length - 1)
				{
					sb.Append(sb2[i]);
					break;
				}
				var firstChar = sb2[i].ToString().ToLower();
					var secondChar = sb2[i+1].ToString().ToLower() ;
					if (firstChar[0] < secondChar[0] || firstChar[0] == secondChar[0])
					{
						sb.Append(sb2[i]);
					}
					else
					{
						
						sb.Append(sb2[i]);

						sb.Append(delimiter);
					}
				
			}
			Console.WriteLine(sb);
		}
	}
}
