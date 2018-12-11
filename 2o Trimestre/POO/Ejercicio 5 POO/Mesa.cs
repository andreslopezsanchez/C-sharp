using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Mesa : Mueble
    {
        public enum TipoMadera
        {
            Roble,
            Pino, 
            Caoza
        }
        private TipoMadera tipoMadera;

    public Mesa(Color color, float peso, Dimensiones dimensiones, string fabricante, float precio, TipoMadera tipoMadera) 
         : base(color, peso, dimensiones, fabricante, precio)
        {
            this.tipoMadera = tipoMadera;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("MESA");
            base.MostrarInformacion();
            Console.WriteLine($"Tipo de madera: {tipoMadera}\n");
            
        }

    }
}
