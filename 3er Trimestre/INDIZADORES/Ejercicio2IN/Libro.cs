using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2IN
{
    public class Libro
    {
        private string titulo;
        private DateTime fecha;
        private Escritor escritor;

        public string Titulo
        {
            get
            {
                return titulo;
            }

            set
            {
                titulo = value;
            }
        }

        public Libro(string titulo,
                    DateTime fecha,
                    Escritor escritor)
        {
            this.titulo = titulo;
            this.fecha = fecha;
            this.escritor = escritor;
        }

        public override string ToString()
        {
            return $"\nTítulo:{titulo} \nFecha de publicación{fecha}";
        }

    }
}
