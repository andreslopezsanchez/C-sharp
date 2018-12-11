using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4INT
{
    class Disc
    {
        private string album;
        private string artist;
        private string[] songs;

        public Disc(string album, string artist, string[] songs)
        {
            this.album = album;
            this.artist = artist;
            this.songs = songs;
        }


        public ushort GetNumTracks()
        {
            return (ushort)songs.Length;
        }

        public string this[int song]
        {
            get { return songs[song]; }
        }

      
        public override string ToString()
        {
            return $"Album:{album} Artist:{artist}";
        }

    }
}
