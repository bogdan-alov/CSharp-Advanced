using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_09.Rectangle_Intersection
{
	class Startup
	{
		static void Main(string[] args)
		{
			var times = Console.ReadLine().Split().Select(int.Parse).ToArray();
			var list = new List<Rectangle>();
			for (int i = 0; i < times[0]; i++)
			{
				var input = Console.ReadLine().Split().ToArray();
				var rectangle = new Rectangle();
				rectangle.ID = input[0];
				rectangle.Width = double.Parse(input[1]);
				rectangle.Height = double.Parse(input[2]);
				rectangle.X = double.Parse(input[3]);
				rectangle.Y = double.Parse(input[4]);
				list.Add(rectangle);

			}

			for (int i = 0; i < times[1]; i++)
			{
				var input = Console.ReadLine().Split().ToArray();
				var firstID = list.FirstOrDefault(c=> c.ID == input[0]);
				var secondID = list.FirstOrDefault(c=> c.ID == input[1]);
				if (firstID.IntersectsWith(secondID))
				{
					Console.WriteLine("true");
				}
				else
				{
					Console.WriteLine("false");
				}
			}

			

		}

		


	}
}
