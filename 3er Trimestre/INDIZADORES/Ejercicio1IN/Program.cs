using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1IN
{
    /*• Crea una clase Jugador que permita guardar el nombre de un jugador y la 
     *  puntuación obtenida en las últimas 10 partidas. 
     *  
     *• Crea un indizador para la puntuación y un método estático PonerPuntuacion 
     *  en la clase programa que te permita generar la puntuación del jugador 
     *  aleatoriamente, utilizando el indizador. 
     * 
     *• Si necesitas saber la longitud del array, crea una propiedad llamada Longitud 
     *  (esta es otra perspectiva de cómo ver las propiedades). 
     *  
     *• El constructor de la clase se encargará de guardar el nombre del jugador, y 
     *  redefiniremos el método ToString en la clase Jugador para mostrar sus datos (nombre, puntuación).*/
    class Program
    {
        public static void PonerPuntuacion(Jugador jugador)
        {
            Console.WriteLine("Poniendo puntuación...");
            Random semilla = new Random();
            for (int i = 0; i < jugador.MaximoPartidas; i++)
            {
               jugador[i] = semilla.Next((int)uint.MinValue,int.MaxValue);
            }
        }

        static void Main(string[] args)
        {
            Jugador jugador = new Jugador("Pepe");
            PonerPuntuacion(jugador);

            Console.WriteLine(jugador);

        }
    }
}
