using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    /* Crea con una función-λ que genere los N primeros términos de la 
     * sucesión de Fibonnaci. 
     * Solución iterativa (Fuente Wikipedia):
     * 
     *      funcion fib(n) 
     *          a ← 0 
     *          b ← 1 
     *          Para k desde 0 hasta n hacer 
     *              b ← b + a 
     *              a ← b – a 
     *          devuelve a
     *          
     * Realiza la misma operación pero ahora usando recursividad con 
     * funciones-λ Solución recursiva (Fuente Wikipedia):
     * 
     *      funcion fib(n) 
     *          si n < 2 entonces 
     *              devuelve n 
     *          en otro caso 
     *              devuelve fib(n - 1) + fib(n - 2)
     */
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Dime un numero para la sucesión de Fibonacci: ");
            int nTerminos = int.Parse(Console.ReadLine());

            Func<int, int> SucesionFib;
            SucesionFib = n =>
            {
                int a = 0;
                int b = 1;
                for (int i = 0; i < n; i++)
                {
                    b = b + a;
                    a = b - a;
                }
                return a;
            };
            

            Console.WriteLine($"Sucesion de Fibonacci de los {nTerminos} primeros terminos sin recursividad: {SucesionFib(nTerminos)}");
            Enumerable.Range(1, nTerminos).ToList().ForEach(x => Console.WriteLine(SucesionFib(x)));

            Func<int, int> SucesionFibRecursiv = null;
            SucesionFibRecursiv = n =>
            {
                if (n<2)
                {
                    return n;
                }
                else
                {
                    return SucesionFibRecursiv(n - 1) + SucesionFibRecursiv(n - 2);
                }
            };

            Console.WriteLine($"Sucesion de Fibonacci de los {nTerminos} primeros terminos CON recursividad: {SucesionFibRecursiv(nTerminos)}");
            Enumerable.Range(0, nTerminos+1).ToList().ForEach(x => Console.WriteLine(SucesionFibRecursiv(x)));
        }
    }
}
