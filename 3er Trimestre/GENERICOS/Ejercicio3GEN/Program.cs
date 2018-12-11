using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3GEN
/* • Partiendo del ejercicio anterior. Crea una clase Persona la cual tendrá solo dos atributos que son Nombre y Edad.  
 * 
 * • Comprueba si funcionan los métodos Mayor y Menor con ella. ¿Qué ocurre?. 
 * 
 * • Ahora haz que la clase derive de IComparable<Persona> y de ICloneable y que invalide ToString(). 
 * 
 * • Haz lo necesario para comprobar el funcionamiento de todo lo que has añadido.*/
{

    interface ICloneable<T> : ICloneable
    {
        new T Clone();
    }

    static class Comparador<T> where T : IComparable<T>
    {
        public static bool Mayor(T p1, T p2){
            if (p1.CompareTo(p2) > 0)
                return true;
            else
                return false;
        }

        public static bool Menor(T p1, T p2){
            if (p1.CompareTo(p2) < 0)
                return true;
            else
                return false;
        }
    }

    class Persona : IComparable<Persona>, ICloneable<Persona>
    {
        private string nombre;
        private int edad;

        public string Nombre
        {
            get
            {
                return nombre;
            }

        }

        public int Edad
        {
            get
            {
                return edad;
            }
        }

        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public int CompareTo(Persona p)
        {
            return this.edad.CompareTo(p.Edad);
        }

    
        public override string ToString() 
        {
            return $"{Nombre}: {Edad}";
        }

        public Persona Clone() // para no castear en el program
        {
            return new Persona(this.Nombre, this.Edad);
        }

        object ICloneable.Clone()
        {
            return Clone();
        }
    }

    class Program
    {  
        static void Main(string[] args)
        {
            Persona p1 = new Persona("antonia", 23);
            Persona p2 = new Persona("federico", 23);
            Console.WriteLine(p1 is ICloneable);
            Console.WriteLine(Comparador<Persona>.Mayor(p1, p2));
         
        }
    }
}
