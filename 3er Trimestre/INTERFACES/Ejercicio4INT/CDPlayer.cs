using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MisInterfaces;


namespace Ejercicio4INT
{
    /// <summary>
    /// holaaa 
    /// </summary>
    class CDPlayer : IMedia
    {
        private ushort track;
        private MediaState state;
        private Disc disc;

        public CDPlayer()
        { 
            track = 1;
            state = MediaState.Playing;
        }

        
     
        public void SetInsert(Disc disc)
        {
            Console.WriteLine("INSERTING CD...");
            this.disc = disc;

        }
        public bool GetCDIn()
        {
            if (disc != null)
                return true;
            else
                return false;
        }   
        public void Extract()
        {
            Console.WriteLine("EXTRACTING CD...");
            disc = null;
        }

        public string GetMessageToDisplay()
        {
            if (GetCDIn() == false)
                return "NO DISC";
            else if (track < disc.GetNumTracks())
            {
                return $"{state.ToString().ToUpper()}... {disc}" +
                $" Track {track} - {disc[track]}";
            }
            else
               return $"{state.ToString().ToUpper()}... {disc}" +
                $" Track {track} - {disc[track-1]}";
        }
        public void Play()
        {
            state = MediaState.Playing;

            if (GetCDIn() == false)
                Console.WriteLine("NO DISC"); 
            else
                Console.WriteLine(GetMessageToDisplay());
        }
        public void Stop()
        {
            state = MediaState.Stopped;

            if (GetCDIn() == false)
                Console.WriteLine("NO DISC");
            else
                Console.WriteLine(GetMessageToDisplay());
            track = 1;
        }
        public void Pause()
        {
            state = MediaState.Paused;

            if (GetCDIn() == false)
                Console.WriteLine("NO DISC");
            else
                Console.WriteLine(GetMessageToDisplay());
        }
        public void Next()
        {
            if (GetCDIn() == false)
                Console.WriteLine("NO DISC");
            else if (track < disc.GetNumTracks())
            {
                track++;
                Console.WriteLine(GetMessageToDisplay());
            }
            else if(track == disc.GetNumTracks())
            {
                track = 1;
                Console.WriteLine(GetMessageToDisplay());
            }
        }
        public void Previous()
        {
            if (GetCDIn() == false)
                Console.WriteLine("NO DISC");
            else if (track == 1)
            {
                track = disc.GetNumTracks();
                Console.WriteLine(GetMessageToDisplay());
            }
            else
            { 
                --track;
                Console.WriteLine(GetMessageToDisplay());
            }
        }
  
    }
}
