using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_B2_C
/*  Implementa el TAD PilaVinculada<T> como envoltorio (wrapper) del tipo de las BCL
    LinkedList<T>.

    El tipo debe implementar los métodos:
        • PilaVinculada<T>()
        • PilaVinculada<T>(IEnumerable coleccion)
        • void Apila(T dato)
        • T Desapila()
        • T Peek()  
        • bool Vacía { get; }   
        • int Elementos { get; }
        • Implemente el interfaz IEnumerable<T>
            
 */
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                

                PilaVinculada<int> pila = new PilaVinculada<int>(new int[] { });
                pila.Apila(5);
                pila.Apila(3);
                pila.Apila(7);

                foreach (int dato in pila)
                {
                    Console.WriteLine(dato);
                }

                Console.WriteLine();

                PilaVinculada<int> pila2 = new PilaVinculada<int>(new int[] { 1, 2, 3, 4 });

                Console.WriteLine(pila2.Desapila());
                Console.WriteLine(pila2.Peek());
                pila2.Apila(8);

                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
