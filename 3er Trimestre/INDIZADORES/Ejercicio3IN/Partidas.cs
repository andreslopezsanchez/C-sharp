using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3IN
{
    class Partidas
    {
        private string nombreJuego;
        private string descripcion;
        private Jugador[] jugadores;

        public int NumeroJugadores
        {
            get
            {
                return jugadores.Length;
            }
        }

        public Partidas(string nombreJuego, string descripcion, int numeroJugadores)
        {
            this.nombreJuego = nombreJuego;
            this.descripcion = descripcion;
            jugadores = new Jugador[numeroJugadores];
        }

        public Jugador this[int j]
        {
            get
            {
                return jugadores[j];
            }
            set
            {
                jugadores[j] = value;
            }

        }

        private static void ponerPuntuacion(Jugador jugador)
        {
            Console.WriteLine($"Poniendo puntuaciones a {jugador.Nombre}...");
            Random semilla = new Random(jugador.GetHashCode() + DateTime.Now.Millisecond);
            for (int i = 0; i < jugador.MaximoPartidas; i++)
            {
                jugador[i] = semilla.Next(0, 101);
            }
        }

        public void LlenaArrayPuntuaciones()
        {
            for (int i = 0; i < NumeroJugadores; i++)
            {
                ponerPuntuacion(jugadores[i] = new Jugador($"Jugador {i+1}"));
            }
        }

        private  string textoJugadores()
        {
            string texto = "";
            for (int i = 0; i < NumeroJugadores; i++)
            {
                texto+=$"\n Jugador{i + 1}:\n\t{jugadores[i]}\n";
            }
            return texto;
        }

        public override string ToString()
        {
            return $"Nombre del juego: {nombreJuego} \nDescripcion: {descripcion}  \n\nJugadores:\n{textoJugadores()}";
        }
    }
}
