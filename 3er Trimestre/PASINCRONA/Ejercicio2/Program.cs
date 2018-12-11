using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Ejercicio2
{
    /* Vamos a ampliar el ejercicio anterior añadiendo música a nuestra aplicación, 
     * para ello, después de lanzar el Timer, intanciaremos un objeto de la clase 
     * System.Media.SoundPlayer, al cual pasaremos un archivo de audio con extensión 
     * .wav y codec PCM que habrás conseguido previamente. 
     * 
     * Dicha clase tiene un método PlayLooping() que empezará a reproducir el archivo 
     * en un hilo aparte. 
     * 
     * Al igual que antes, al pulsar cualquier tecla, tanto el timer como la música pararán 
     * y, volverán a reanudarse, si se vuelve a pulsar una tecla. Como en el ejercicio 
     * anterior, el programa parará si pulsamos ESC. 
     * 
     * Nota: Ten en cuenta que tanto Timer como SounPlayer son disposables y por tanto 
     * deberás instanciarlos dentro de una clausula using.*/

    // el codec tiene que ser PCM

    class Program
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        static void SituaYDibuja(
                        int col, int fila, 
                        string texto, 
                        ConsoleColor colorFondo, 
                        ConsoleColor colorLetra)
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(col, fila);
            Console.BackgroundColor = colorFondo;
            Console.ForegroundColor = colorLetra;
            Console.Write(texto);
            Console.ResetColor();
        }

        static void Main(string[] args)
        {
            using (SoundPlayer audio = new SoundPlayer("prueba2.wav"))
            {
                Timer temporizador = new Timer() { Interval = 1000, Enabled = true, AutoReset = true };
                temporizador.Elapsed += Temporizador_Elapsed;
                ConsoleKeyInfo teclado;

                audio.PlayLooping();
                do
                {                    
                    teclado = Console.ReadKey();
                    if (teclado.Key != ConsoleKey.Escape)
                    {
                        if (!temporizador.Enabled)
                        {
                            audio.PlayLooping();
                            temporizador.Start();
                        }
                        else
                        {
                            audio.Stop();
                            temporizador.Stop();
                        }
                    }
                    else
                        temporizador.Close();

                } while (teclado.Key != ConsoleKey.Escape);
            }
        }

        private static void Temporizador_Elapsed(object sender, ElapsedEventArgs e)
        {
            SituaYDibuja(20, 1, $"Reproduciendo: Banana Duck - Anastesia", ConsoleColor.DarkCyan, ConsoleColor.White);
            SituaYDibuja(80, 1, $"{e.SignalTime.ToLongTimeString()}", ConsoleColor.DarkCyan, ConsoleColor.White);
            SituaYDibuja(1, 2, $"", ConsoleColor.Black, ConsoleColor.White);
        }
    }
}
