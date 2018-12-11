using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Local
    {
    
        public struct Dimensiones
        {
           public float alto_m;
           public float ancho_m;
           public float profundo_m;
        }

        private Dimensiones dimensiones;
        private string ciudad;
        private string calle;
        private ushort numeroPlantas;

        public Local(string ciudad, 
                     string calle, 
                     ushort numeroPlantas,
                     Dimensiones dimensiones)
        {
            this.ciudad = ciudad;
            this.calle = calle;
            this.numeroPlantas = numeroPlantas;
            this.dimensiones = dimensiones;
        }


        public ushort GetNumeroPlantas()
        {
            return numeroPlantas;
        }
        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Ciudad: {ciudad}");
            Console.WriteLine($"Calle: {calle}");
            Console.WriteLine($"Numero de plantas: {GetNumeroPlantas()}");
            Console.WriteLine($"Dimensiones (metros):\n" +
                                $"\tAncho:{dimensiones.ancho_m}\n" +
                                $"\tAlto:{dimensiones.alto_m}\n" +
                                $"\tProfundo:{dimensiones.profundo_m}\n");
        } 
    }
}
