using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3IN
{
    /* • A partir del ejercicio 1 deberás crearte una clase Partidas que tendrá 
     *   el nombre del juego, la descripción y una array de tipo Jugador. 
     * 
     * • El método PonerPuntuacion seguirá siendo estático pero lo pasaremos a la nueva clase. 
     * 
     * • Además, implementaremos un método más LlenaArrayPuntuaciones que generará las 
     *   puntuaciones de todos los jugadores usando PonerPuntuacion. 
     *   
     * • Método ToString que generará la información de la partida y de los jugadores llamando 
     *   al Mostrar de ToString. 
     *   
     * • Crea un programa principal y los métodos necesarios para su correcto funcionamiento y prueba.*/
    class Program
    {
        static void Main(string[] args)
        {
            Partidas partida = new Partidas("Futbol", "aqui ponemos la descripcion", 4);
            partida.LlenaArrayPuntuaciones();
            Console.WriteLine(partida);
        }
    }
}
