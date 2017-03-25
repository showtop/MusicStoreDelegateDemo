using System;
using System.Collections.Generic;

namespace MusicStore
{
    class Playlist
    {
        // delegate for showing song
        public delegate bool ProcessPlaylistDelegate(Song song);

        private List<Song> list = new List<Song>();

        public List<Song> List { get => this.list; set => this.list = value; }

        //add song to playlist
        public void AddSong(string title, string artist, string format)
        {
            this.list.Add(new Song { Title = title, Artist = artist, Format = format });
        }

        //show the playlist using another function attached to ProcessPlaylistDelegate
        public void ShowPlaylist(ProcessPlaylistDelegate processPlaylist)
        {
            foreach (Song song in this.list)
            {
                if (processPlaylist(song))
                {
                    Console.WriteLine("Song Title: {0}", song.Title);
                }
            }
        }
    }
}
