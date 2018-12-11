using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Persona
    {
        public enum Sexo
        {
            hombre,
            mujer
        }
        private string nombre;
        private ushort edad;
        private float peso;
        private Sexo sexo;

        public Persona(string nombre, ushort edad, float peso, Sexo sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.peso = peso;
            this.sexo = sexo;
        }

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
        
    }
}
