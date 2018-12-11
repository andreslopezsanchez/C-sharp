using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MisInterfaces;

namespace Ejercicio4INT
{
    class DABRadio : IMedia
    {
        const float SEEK_STEP = 0.5f;
        const float MAX_FREQUENCY = 108.1f;
        const float MIN_FREQUENCY = 88.1f;

        private float frequency;
        private MediaState state;

        public DABRadio()
        {
            frequency = MIN_FREQUENCY;
            state = MediaState.Paused;
        }

        public string GetMessageToDisplay()
        {
            if(state == MediaState.Playing)
                return $" HEARING...FM - {frequency}";
            if (state == MediaState.Stopped)
                return "RADIO OFF";
            if (state == MediaState.Paused)
                return $" PAUSED - BUFFERING...FM - {frequency}";
            else
                return "RADIO OFF";
        }
        /// <summary>
        /// le das al play
        /// </summary>
        public void Play()
        {
            if (state == MediaState.Stopped)
            {
                frequency = MIN_FREQUENCY;
            }
            state = MediaState.Playing;

            Console.WriteLine(GetMessageToDisplay());
        }
        public void Stop()
        {
            state = MediaState.Stopped;
            Console.WriteLine(GetMessageToDisplay());
        }
        public void Pause()
        {
            if (state != MediaState.Stopped)
            {
                state = MediaState.Paused;
                Console.WriteLine(GetMessageToDisplay());
            }
            else
                Console.WriteLine("RADIO OFF");
        }
        public void Next()
        {
            if (frequency < MAX_FREQUENCY)
            {
                frequency += SEEK_STEP;
                Console.WriteLine(GetMessageToDisplay());
            }
            else
            {
                frequency = MIN_FREQUENCY;
                Console.WriteLine(GetMessageToDisplay());
            }
        }   
        public void Previous()
        {
            if (frequency == MIN_FREQUENCY)
            {
                frequency = MAX_FREQUENCY;
                Console.WriteLine(GetMessageToDisplay());
            }
            else
            {
                frequency -= SEEK_STEP;
                Console.WriteLine(GetMessageToDisplay());
            }
        }
     
    }
}
