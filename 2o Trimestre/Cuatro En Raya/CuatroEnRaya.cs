using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class CuatroEnRaya
    {

        public static void DibujaCabeceraYMarcadores(string jugador0, string jugador1)
        {
            Console.WriteLine($"{"4 en línea Programación 1ºDAM",40}");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("  ",19);
            Console.ResetColor();
            Console.Write($"{jugador0}");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("  ",39);
            Console.ResetColor();
            Console.Write($"{jugador1}");

            Console.WriteLine();
        }

        public static void InicializaJuego(out string jugador0, out string jugador1)
        {
            Console.WriteLine("Datos de los jugadores...\n");

            Console.Write("Nombre de pila del jugador 0: ");
            jugador0 = Console.ReadLine();
            Console.Write("Nombre de pila del jugador 1: ");
            jugador1 = Console.ReadLine();

        }
        static void Main(string[] args)
        {
            string jugador0, jugador1;
            int contador0 = 0;
            int contador1 = 0;
            InicializaJuego(out jugador0, out jugador1);
            Console.Clear();

            DibujaCabeceraYMarcadores(jugador0, jugador1);

            
        }
    }
}
