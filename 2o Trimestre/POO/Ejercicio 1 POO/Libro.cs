using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class Libro
    {
        private string titulo;
        private DateTime fecha;
        private Escritor escritor;

        public Libro()
        {
            titulo = "";
            fecha = new DateTime();
            escritor = new Escritor();
        }
        public Libro(string titulo,
                    DateTime fecha,
                    Escritor escritor)
        {
            this.titulo = titulo;
            this.fecha = fecha;
            this.escritor = escritor;
        }
        public Libro(Libro libro)
        {
            titulo = libro.titulo;
            fecha = libro.fecha;
            escritor = libro.escritor;
        }

        public string GetNombre()
        {
            return escritor.GetNombre();
        }
        public void SetEscritor(Escritor escritor)
        {
            
        }
    }
}
