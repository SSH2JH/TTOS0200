using System;
using System.Collections.Generic;

namespace OOP.Tasks {
	class MusicDisk {
		public string AlbumName { get; set; }
		public string ArtistName { get; set; }
		public string AlbumGenre { get; set; }
		public List<Song> Songs { get; }
		private int songAmount = 0;

		public MusicDisk()
		{
			Songs = new List<Song>();
		}
		public string AddSong(Song song)
		{
			Songs.Add(song);
			songAmount++;
			return "--> Added song \"" + song.SongName + "\" Lenght: " + song.LenghtSeconds;
		}
	}
	class Song {
		public string SongName { get; set; }
		public int LenghtSeconds { get; set; }

	}
}
