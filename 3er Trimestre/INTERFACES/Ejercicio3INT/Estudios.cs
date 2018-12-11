using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MisInterfaces;

namespace Ejercicio3INT
{
    abstract class Estudios : IEstudios, IVisualiza
    {
        private string nombre;
        private int duracion_mes;

        public string Nombre
        {
            get { return nombre; }
        }

        public Estudios(string nombre, int duracion_mes)
        {
            this.nombre = nombre;
            this.duracion_mes = duracion_mes;
        }

        public abstract void EdadMinima();
 

        public virtual void Visualiza()
        {
            Console.WriteLine($"Nombre asignatura: {nombre}");
            Console.WriteLine($"Duracion en meses: {duracion_mes}");
        }
    }
}
