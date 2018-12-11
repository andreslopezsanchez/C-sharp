using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MisInterfaces;

namespace Ejercicio3INT
{
    class Superior : Estudios
    {
        private string lugar;

        public Superior(string nombre, int duracion_mes, string lugar) : base(nombre, duracion_mes)
        {
            this.lugar = lugar;
        }

        
        public override void EdadMinima()
        {
            Console.WriteLine("La edad mínima son 18 años\n\n");
        }

        public override void Visualiza()
        {
            Console.WriteLine("ESTUDIOS SUPERIORES");
            base.Visualiza();
            Console.WriteLine($"Lugar: {lugar}");
        }
    }
}
