using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic.ListExtensions;
using Ejercicio4;
/* Vamos a crear un par de métodos extensores de la clase List<T> implementada por Microsoft en System.Collections.Generic. 
 * Para ello define el namespace System.Collections.Generic.ListExtensions y dentro de él crea las clases que estimes oportunas 
 * para que: 
 *      • Tener un método extensor SecuenciaAleatoria que reciba el número de elementos N a generar y devuelva una lista de elementos
 *        del mismo tipo con N elementos de la lista original escogidos de forma aleatoria y no repetidos. 
 *      • Tener un método extensor SecuenciaAleatoriaConRepeticiones que reciba el número de elementos N a generar y devuelva lo 
 *        mismo que el anterior pero admitiendo repeticiones. Prueba tus métodos extensores con el siguiente código ...
 *       
 * Teniendo en cuenta que: 
 *      • No se deben repetir las secuencias. 
 *      • No debes repetir código en la implementación de tus métodos extensores. 
 *      • numeros.SecuenciaAleatoriaConRepeticiones(15) no debe producir excepciones aunque la lista de números sea menor que la 
 *        nueva secuencia porque admite repeticiones. • numeros.SecuenciaAleatoria(15) debe producir excepción porque tiene menos 
 *        elementos en la secuencia a elegir que los solicitados. 
 */

namespace System.Collections.Generic.ListExtensions
{
    public static class ListExtension
    {
        private static int seed = DateTime.Now.Millisecond;

        private static List<T> creaYAñadeASubLista<T>(List<T> lista, int repeticiones, bool hayRepeticiones = true)
        {
            Random aletatorio = new Random(seed++);
            List<T> subLista = new List<T>();
            int contador = 0;

            while(contador<repeticiones)
            {
                int numAleatorio = aletatorio.Next(lista.Count.GetHashCode());
                if (!hayRepeticiones)
                {                    
                    if (!subLista.Contains(lista[numAleatorio]))
                    {
                        subLista.Add(lista[numAleatorio]);
                        contador++;
                    }                        
                }
                else
                {
                    subLista.Add(lista[numAleatorio]);
                    contador++;
                }
            }

           return subLista;
        }

        public static List<T> SecuenciaAleatoria<T>(this List<T> lista, int n)
        {
         
            if (n >  lista.Count)
            {
                throw new ListExtensionException("La lista tiene menos elementos que el numero dado");
            }
            else
            {
                return creaYAñadeASubLista<T>(lista, n, false);              
                       
            }
        
        }
        public static List<T> SecuenciaAleatoriaConRepeticiones<T>(this List<T> lista, int n)
        {

            return creaYAñadeASubLista<T>(lista, n);
        }
    }

}

namespace Ejercicio4
{
    class ListExtensionException : Exception
    {
        public ListExtensionException(string message) : base(message)
        {
            ;
        }
    }
        
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                
                foreach (var n in numeros.SecuenciaAleatoria(5)) Console.Write($"{n} "); Console.Write($"\n");
                foreach (var n in numeros.SecuenciaAleatoriaConRepeticiones(6)) Console.Write($"{n} "); Console.Write($"\n");
                foreach (var n in numeros.SecuenciaAleatoriaConRepeticiones(15)) Console.Write($"{n} "); Console.Write($"\n");
                foreach (var n in numeros.SecuenciaAleatoria(15)) Console.Write($"{n} ");
            }
            catch (ListExtensionException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
