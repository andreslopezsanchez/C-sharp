using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_B2_C
/*
    Implementa el TAD ColaVinculada<T> como envoltorio (wrapper) del tipo de las BCL
    LinkedList<T>.

    El tipo debe implementar los métodos:
• ColaVinculada<T>()
• ColaVinculada<T>(IEnumerable coleccion)
• void Encola(T dato)
• T Desencola()
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

                ColaVinculada<int> cola = new ColaVinculada<int>();
                cola.Encola(5);
                cola.Encola(3);
                cola.Encola(7);

                foreach (int dato in cola)
                {
                    Console.WriteLine(dato);
                }
                Console.WriteLine();

                ColaVinculada<int> cola2 = new ColaVinculada<int>(new int[] { 1, 2, 3, 4 });

                Console.WriteLine(cola2.Desapila());
                Console.WriteLine(cola2.Peek());
                cola2.Encola(8);
                Console.WriteLine();
                foreach (int dato in cola2)
                {
                    Console.WriteLine(dato);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
