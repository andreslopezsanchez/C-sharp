using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2GEN
/* • Crea una clase estática genérica llamada Comparador<T> que posea a su vez 
 *   dos métodos de utilidad estáticos llamados Mayor y Menor. 
 *   
 * • Ambos reccibirán dos parámetros del tipo genérico, y devolverán true o 
 *   false en el caso que el primer parámetro sea mayor que el segundo y vicenversa. 
 *   
 * • ¿Qué problemas has encontrado?. 
 * 
 * • La mejor forma de solucionarlo es obligando a que el parámetro genérico 
 *   implemete de IComparable<T>. 
 *   
 * • Crea una clase programa que te permita probar estos métodos, mandándole 
 *   diferentes elementos, enteros, strings, float, etc.*/
{
    static class Comparador<T> where T : IComparable<T>
    {      

        public static bool Mayor(T p1, T p2)
        {

            if (p1.CompareTo(p2) == 1)
                return true;
            else
                return false;
            
        }

        public static bool Menor(T p1, T p2)
        {
            if (p1.CompareTo(p2) == -1)
                return true;
            else
                return false;
        }

       
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Comparador<int>.Mayor(1,4));
            Console.WriteLine(Comparador<string>.Mayor("hola que tal", "federico"));

            Console.WriteLine(Comparador<float>.Menor(7.1234f, 4.68f));
        }
    }
}
