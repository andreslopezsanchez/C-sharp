using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MisInterfaces;

namespace Ejercicio3INT
{
    class Medio : Estudios
    {
        private Superior estudioSuperior;

        public Medio(string nombre, int duracion_mes, Superior estudioSuperior) : base(nombre, duracion_mes)
        {
            this.estudioSuperior = estudioSuperior;
        }

        public override void EdadMinima()
        {
            Console.WriteLine("La edad mínima son 16 años\n\n");
        }

        public override void Visualiza()
        {
            Console.WriteLine("ESTUDIOS MEDIOS");
            base.Visualiza();
            if (estudioSuperior != null)
                Console.WriteLine($"Con  este ciclo tienes salidad para cursar el superior: {estudioSuperior.Nombre}");//
            else
                Console.WriteLine("No tienes acceso a ningun ciclo superior");
        }
    }
}
