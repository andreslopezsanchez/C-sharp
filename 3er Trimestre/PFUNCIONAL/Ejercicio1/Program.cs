using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
 /* Crea una aplicación que a partir de una Lista de enteros, te muestre 
  * los múltiplos de un número introducido por teclado que existan en la 
  * lista, usando funciones-λ  y el operador ?:*/
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            lista.Add(8);
            lista.Add(46);
            lista.Add(18);
            lista.Add(9);
            lista.Add(5);
            lista.Add(3);
            lista.Add(12);

            Console.Write("Dime numero: ");
            int numero = int.Parse(Console.ReadLine());
            
            lista.FindAll( i => i % numero == 0).ForEach(a => Console.WriteLine(a));

            lista.ForEach(a => Console.WriteLine((a % numero == 0) ? $"{a}" : "\0"));
        }
    }
}
