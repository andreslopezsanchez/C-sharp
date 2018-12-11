using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Cine : LocalComercial
    {
        /*         * La clase Cine que heredará de LocalComercial.
         *      • Con el campo aforo sala.
         *      • Con la operación Mostrar que visualizará por la consola los datos de un cine.*/
        private ushort aforoSala;

        public Cine(string ciudad, string calle, 
                    ushort numeroPlantas, Dimensiones dimensiones, 
                    string razonSocial, int numeroLicencia, ushort aforoSala) 
             : base(ciudad, calle, numeroPlantas, dimensiones, razonSocial, numeroLicencia)
        {
            this.aforoSala = aforoSala;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Aforo de la sala: {aforoSala}\n\n");
        }
    }
}
