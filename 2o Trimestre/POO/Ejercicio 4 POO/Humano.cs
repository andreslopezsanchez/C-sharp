using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Humano
    {
        /*Crea una clase Humano con los campos, como mínimo: nombre, edad, peso, sexo, inteligencia, 
     * fuerza, destreza y energía. 
     * 
     * Los métodos MostrarInformación, SetNombre, SetEdad,...y los constructores que creas necesarios.*/

        public enum Sexo
        {
            hombre,
            mujer
        }
        private string nombre;
        private ushort edad;
        private float peso;
        private Sexo sexo;
        private int inteligencia;
        private int fuerza;
        private int energia;

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void SetEdad(ushort edad)
        {
            this.edad = edad;
        }
        public void SetPeso(float peso)
        {
            this.peso = peso;
        }
        public void SetSexo(Sexo sexo)
        {
            this.sexo = sexo;
        }
        public void SetInteligencia(int inteligencia)
        {
            this.inteligencia = inteligencia;
        }
    }
}
