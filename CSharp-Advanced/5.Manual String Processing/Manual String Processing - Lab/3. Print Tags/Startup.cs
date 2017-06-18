using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Print_Tags
{
	class Startup
	{
		static void Main(string[] args)
		{
			var inputText = Console.ReadLine();
			var openTag = "<upcase>";
			var closeTag = @"</upcase>";
			int startIndex = inputText.IndexOf(openTag);
			//We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase>else.
			while (startIndex != -1)
			{
				var endIndex = inputText.IndexOf(closeTag);
				if (endIndex != -1)
				{
					var text1 = inputText.Substring(startIndex, endIndex + closeTag.Length - startIndex);
					var text =text1.Replace(openTag, "");
					text = text.Replace(closeTag, "");
					text = text.ToUpper();
					inputText = inputText.Replace(text1, text);
					
				}
				else
				{
					break;
				}
				startIndex = inputText.IndexOf(openTag);
			}
			Console.WriteLine(inputText);
		}
	}
}
