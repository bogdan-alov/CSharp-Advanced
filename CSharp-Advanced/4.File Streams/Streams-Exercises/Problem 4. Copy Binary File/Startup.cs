using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Copy_Binary_File
{
	class Startup
	{
		static void Main(string[] args)
		{
			using (var sourceImage = new FileStream(@"../../twitch.jpg", FileMode.Open))
			{
				using (var result = new FileStream(@"../../result.jpg", FileMode.Create))
				{

					byte[] buffer = new byte[4096];
					while (true)
					{
						int readBytes = sourceImage.Read(buffer, 0, buffer.Length );
						if (readBytes == 0)
						{
							break;
						}

						result.Write(buffer, 0, readBytes);

					}
				}
			}
		}
	}
}
