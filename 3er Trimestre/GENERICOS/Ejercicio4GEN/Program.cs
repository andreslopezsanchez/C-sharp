using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4GEN
/* • Crea una clase genérica ParOrdenado<T> con dos atributos denominados primero y segundo 
 * 
 * • Crea el correspondiente constructor, propiedades y el método ToString 
 * 
 * • Además, añade un indizador de solo lectura que dependiend de si el índice es 0 te devolverá el 
 *   valor de atributo primero y si es 1 el valor de atributo segundo (Una excepción en cualquier otro caso). 
 * 
 * • Crea un programa que te permita probar esta clase usando enteros y cadenas.*/
{
    class ParOrdenado<T>
    {
        private T primero;
        private T segundo;

        public ParOrdenado(T primero, T segundo)
        {
            this.primero = primero;
            this.segundo = segundo;
        }

        public T Primero
        {
            get
            {
                return primero;
            }
        }
        public T Segundo
        {
            get
            {
                return segundo;
            }
        }

        public T this[int d]
        {
            get
            {
                if (d == 0)
                    return Primero;
                else if (d == 1)
                    return Segundo;
                else
                    throw new Exception("índice no correcto");
            }
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ParOrdenado<int> p1 = new ParOrdenado<int>(2, 4);

                Console.WriteLine($"{p1[0]} {p1[1]}");

                ParOrdenado<string> p2 = new ParOrdenado<string>("hola", "que tal");

                Console.WriteLine($"{p2[0]} {p2[1]}!!");

                Console.WriteLine($"{p2[3]}");
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
