using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Silla : Mueble
    {
        private float longitudRespaldo_m;

        public Silla(Color color, float peso, Dimensiones dimensiones, string fabricante, float precio, float longitudRespaldo_m)
            : base(color, peso, dimensiones, fabricante, precio)
        {
            this.longitudRespaldo_m = longitudRespaldo_m;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("SILLA");
            base.MostrarInformacion();
            Console.WriteLine($"Longitud del respaldo(metros): {longitudRespaldo_m}\n");
        }
    }
}
