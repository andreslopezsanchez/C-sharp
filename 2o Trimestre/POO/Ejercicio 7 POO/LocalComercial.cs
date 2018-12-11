using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class LocalComercial : Local
    {
        private string razonSocial;
        private int numeroLicencia;

        public LocalComercial(string ciudad, string calle, 
                              ushort numeroPlantas, Dimensiones dimensiones, 
                              string razonSocial, int numeroLicencia) 
             : base(ciudad, calle, numeroPlantas, dimensiones)
        {
            this.razonSocial = razonSocial;
            this.numeroLicencia = numeroLicencia;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Razon social: {razonSocial}");
            Console.WriteLine($"Numero de licencia: {numeroLicencia}");
        }
    }
}
