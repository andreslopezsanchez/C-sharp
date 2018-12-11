using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Sofa : Mueble
    {
        public enum TipoTela
        {
            Algodon,
            Licra, 
            Poliester
        };

        private TipoTela tipoTela;
        private bool esAbatible;

        public Sofa(Color color, float peso, Dimensiones dimensiones, string fabricante, float precio, TipoTela tipoTela, bool esAbatible)
             : base(color, peso, dimensiones, fabricante, precio)
        {
            this.tipoTela = tipoTela;
            this.esAbatible = esAbatible;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("SOFA");
            base.MostrarInformacion();
            Console.WriteLine($"Tipo de tela: {tipoTela}");
            if (esAbatible)
                Console.WriteLine("Es abatible\n");
            else
                Console.WriteLine("No es abatible\n");
        }
    }
}
