using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.Text_Filter
{
	class Startup
	{
		static void Main(string[] args)
		{
			var array = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
			var text = Console.ReadLine();
			foreach (var item in array)
			{
				if (text.Contains(item))
				{
					text = text.Replace(item, new string('*', item.Length));
				}
			}
			Console.WriteLine(text);
		}
	}
}
