using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1IN
{
    class Jugador
    {
        private string nombre;
        private int[] puntuaciones;

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public int this[int p]
        {
            get
            {
                return puntuaciones[p];
            }
            set
            {
                puntuaciones[p] = value;
            }
        }

        public Jugador(string nombre)
        {
            this.nombre = nombre;
            puntuaciones = new int[10];
          
        }


        public int MaximoPartidas
        {
            get { return puntuaciones.Length; }
        }





        private string mostrarPuntuaciones()
        {
            string texto = "";
            for (int i = 0; i < puntuaciones.Length ; i++)
            {
                texto += $"\nPartida {i+1} -> {puntuaciones[i]}";
            }
            return texto;
        }

        public override string ToString()
        {
            return $"Nombre:{Nombre} \nPuntuacion:{mostrarPuntuaciones()}";
        }
    }
}
