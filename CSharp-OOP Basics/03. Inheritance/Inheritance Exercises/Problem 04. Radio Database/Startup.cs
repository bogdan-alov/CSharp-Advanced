using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_04.Radio_Database
{
	class Startup
	{
		static void Main()
		{
			var n = int.Parse(Console.ReadLine());
			var songs = new List<Song>();
			for (int i = 0; i < n; i++)
			{
				try
				{
					var input = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
					var array = new int[2];
					try
					{
						array = input[2].Split(':').Select(int.Parse).ToArray();

					}
					catch (Exception e)
					{
						throw new Exception("Invalid song length.");
					}

					var minutes = array[0];
					var seconds = array[1];

					var song = new Song(input[0], input[1],minutes, seconds);
					songs.Add(song);
					Console.WriteLine("Song added.");
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);		
				}
				
			}

			var timespan = new TimeSpan();
			timespan = TimeSpan.FromSeconds(songs.Sum(c => c.SongLength));
			Console.WriteLine($"Songs added: {songs.Count}");
			Console.WriteLine($"Playlist length: {timespan.Hours}h {timespan.Minutes}m {timespan.Seconds}s");
		}
	}
}
