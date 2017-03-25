using MusicStore;
using System;

namespace MusicStoreClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Playlist playlist1 = new Playlist();

            playlist1.AddSong("Symphony", "Clean Bandit", "mp3");
            playlist1.AddSong("Passionfruit", "Drake", "cd");
            playlist1.AddSong("Green Light", "Lorde", "mp3");
            playlist1.AddSong("Good Life", "KYLE", "mp3");

            Console.WriteLine("MP3s in Playlist");
            playlist1.ShowPlaylist(new Playlist.ProcessPlaylistDelegate(GetMp3Songs));
            Console.WriteLine("----------------------\n");

            Console.WriteLine("CDs in Playlist");
            playlist1.ShowPlaylist(new Playlist.ProcessPlaylistDelegate(GetCdSongs));
            Console.WriteLine("----------------------\n");

            Console.WriteLine("Playlist");
            playlist1.ShowPlaylist(new Playlist.ProcessPlaylistDelegate(GetAllSongs));
            Console.WriteLine("----------------------\n");
        }

        public static bool GetMp3Songs(Song song)
        {
            //more logic goes here
            return (song.Format == "mp3");
        }

        public static bool GetCdSongs(Song song)
        {
            //more logic goes here
            return (song.Format == "cd");
        }

        public static bool GetAllSongs(Song song)
        {
            //more logic goes here
            return true;
        }
    }
}
