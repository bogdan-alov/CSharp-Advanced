using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_04.Radio_Database
{
	class Song
	{
		public Song(string artist, string name, int minutes,int seconds)
		{
			this.Artist = artist;
			this.Name = name;
			this.Minutes = minutes;
			this.Seconds = seconds;
		}
		private string artist;

		public string Artist
		{
			get { return artist; }
			set
			{
				if (value.Length < 3 || value.Length > 30)
				{
					throw new Exception("Artist name should be between 3 and 20 symbols.");
				}
				artist = value;
			}
		}


		private string name;

		public string Name
		{
			get { return name; }
			set
			{
				if (value.Length < 3 || value.Length > 30)
				{
					throw new Exception("Song name should be between 3 and 30 symbols.");
				}
				name = value;
			}
		}

		
		public int SongLength
		{
			get
			{
				return this.CalculateSongLength();
			}
		}
		private int seconds;

		public int Seconds
		{
			get { return seconds; }
			set

			{
				if (value < 0 || value > 59)
				{
					throw new Exception("Song seconds should be between 0 and 59.");
				}
				seconds = value;
			}
		}

		private int minutes;

		public int Minutes
		{
			get { return minutes; }
			set
			{
				if (value < 0 || value > 14)
				{
					throw new Exception("Song minutes should be between 0 and 14.");
				}
				minutes = value;
			}
		}


		private int CalculateSongLength()
		{
			var secs = minutes * 60 + seconds;


			return secs;
		}
	}
}
