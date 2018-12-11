using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MisInterfaces;

namespace Ejercicio4INT
{
    class DABRadioCD : IMedia
    {
        //private IMedia activeDevice;
        private CDPlayer reproductor;
        private DABRadio sintonizador;

        public DABRadioCD()
        {
            reproductor = new CDPlayer();
            sintonizador = new DABRadio();
        }

        public void SetInsertCD(Disc cd)
        {           
            SwitchMode();
            if (reproductor.GetCDIn() == false)
                reproductor.SetInsert(cd);
            else
                throw new Exception("Ya hay un CD DENTRO");
        }
        public void ExtractCD()
        {
            
            reproductor.Extract();
            SwitchMode();

        }
        public void SwitchMode()
        {
            if (sintonizador != null)
            {
                Console.WriteLine("....MODE CD...");
                sintonizador = null;
                reproductor = new CDPlayer();
            }
            else
            {
                Console.WriteLine("...MODE RADIO...\n");
                reproductor = null;
                sintonizador = new DABRadio();

            }
        }


        public string GetMessageToDisplay()
        {
            if (reproductor != null)
            {
                return reproductor.GetMessageToDisplay();
            }
            else
                return sintonizador.GetMessageToDisplay();
        }
        public void Play()
        {
            if (reproductor != null)
            {
                reproductor.Play();
            }
            else
                sintonizador.Play();
        }
        public void Stop()
        {
            if (reproductor != null)
            {
                reproductor.Stop();
            }
            else
                sintonizador.Stop();
        }
        public void Pause()
        {
            if (reproductor != null)
            {
                reproductor.Pause();
            }
            else
                sintonizador.Pause();
        }
        public void Next()
        {
            if (reproductor != null)
            {
                reproductor.Next();
            }
            else
                sintonizador.Next();
        } 
        public void Previous()
        {
            if (reproductor != null)
            {
                reproductor.Previous();
            }
            else
                sintonizador.Previous();
        }
     
    }
}
