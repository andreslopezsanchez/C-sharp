using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MisInterfaces;

namespace Ejercicio3INT
{
    class Elemental : Estudios
    {
        public Elemental(string nombre, int duracion_mes) : base(nombre, duracion_mes)
        {
            ;
        }

        public override void EdadMinima()
        {
            Console.WriteLine("La edad mínima son 12 años\n\n");
        }

        public override void Visualiza()
        {
            Console.WriteLine("ESTUDIOS ELEMENTALES");
            base.Visualiza();
        }
    }
}
