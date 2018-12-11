using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Ejercicio1
{
    /* Vamos a crear una aplicación de consola que su programa principal lance un temporizador 
     * que cada segundo muestre en la parte superior derecha de la pantalla la hora actual 
     * del sistema en formato HH:MM:SS. 
     * Tras lanzar el temporizador el programa principal se quedará esperando una pulsación 
     * de teclado con ReadKey() y si pulsamos ESC el temporizador parará y saldremos del 
     * programa. Pero si pulsamos cualquier otra tecla el temporizador parará o se reiniciará 
     * según su estado anterior*/

        //tamaño de la consola 80x24

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
            Console.Write(texto); Console.ResetColor();
        }

        static void Main(string[] args)
        {
            Timer temporizador= new Timer() { Interval=1000, Enabled=true, AutoReset=true};
            temporizador.Elapsed += Temporizador_Elapsed;
            
            ConsoleKeyInfo teclado;
            do
           {
                temporizador.Start();
                teclado = Console.ReadKey();
            if (teclado.Key != ConsoleKey.Escape)
                temporizador.Stop();
            else
                temporizador.Close();
           
            } while (teclado.Key != ConsoleKey.Escape );
           
        }

        private static void Temporizador_Elapsed(object sender, ElapsedEventArgs e)
        {            
            SituaYDibuja(80, 1, $"{e.SignalTime.ToLongTimeString()}", ConsoleColor.DarkCyan, ConsoleColor.White);
        }
    }
}
