using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4PEP
{
    class Timbre
    {
        private int duracion;

        public Timbre(int duracion)
        {
            this.duracion = duracion;
        }

        public int Duracion
        {
            get
            {
                return duracion;
            }

            set
            {
                duracion = value;
            }
        }

        public void Activar()
        {
            Console.WriteLine("¡Timbre activado!");
        }
        public void Desactivar()
        {
            Console.WriteLine("...Timbre desactivado...");
        }
    }
}
