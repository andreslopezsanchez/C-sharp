using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
   /* Declara una clase abstracta Legislador que herede de la clase Persona, con un campo povinciaQueRepresenta(tipo String)
     * y otros atributos que creas necesarios.*/
    abstract class Legislador : Persona
    {
        private int numeroLeyesAplicadas;
        private string provinciaQueRepresenta;
      

        public Legislador(string nombre, ushort edad, float peso, 
                          Sexo sexo, int numeroLeyesAplicadas, 
                          string provinciaQueRepresenta) 
             : base(nombre, edad, peso, sexo)
        {
            this.numeroLeyesAplicadas = numeroLeyesAplicadas;
            this.provinciaQueRepresenta = provinciaQueRepresenta;        
        }

        public abstract string GetCamaraEnQueTrabaja()
        {
            return null;
        }

        public void Mostrar()
        {

        }
    }
}
