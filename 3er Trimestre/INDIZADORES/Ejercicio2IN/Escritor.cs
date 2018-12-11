using System;
using System.Diagnostics;

namespace Ejercicio2IN
{
    public  class Escritor
    {
        private string nombre;
        private string alias;
        private DateTime nacimiento;
        private DateTime muerte;
        private Libro[] libro;

       public Libro this[int l]
        {
            get
            {
                return libro[l];
            }
            set
            {
                libro[l] = value;
            }
        }

      /*  public Libro this[int posicionLibro]
        {
            
        }*/

        public Escritor(string nombre, string alias, DateTime nacimiento, 
                        DateTime muerte, int numeroLibros)
        {
            this.nombre = nombre;
            this.alias = alias;
            this.nacimiento = nacimiento;
            this.muerte = muerte;
            libro = new Libro[numeroLibros];
                       
        }

        public int CantidadLibros
        {
            get
            {
                return libro.Length;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        private string mostrarLibros()
        {
            string mensaje = "";

            for (int i = 0; i < libro.Length; i++)
            {
                mensaje += $"{libro[i]}\n";
            }
            return mensaje;
        }

        public override string ToString()
        {
            return $"Autor:{nombre} \nAlias:{alias} \nNacimiento:{nacimiento} \nMuerte:{muerte} \nLibros:\n\t{mostrarLibros()}";
        }
    }
}
