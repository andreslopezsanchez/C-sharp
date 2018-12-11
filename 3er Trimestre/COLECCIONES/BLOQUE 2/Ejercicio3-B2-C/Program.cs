using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_B2_C
/*
    Para realizar el ejercicio usa el tipo ColaVinculada que has creado en el ejercicio 2.
    Implementa un método llamado SumaCola que reciba una cola de doubles como
    parámetro (ya creada previamente), y vaya extrayendo uno a uno los elementos del
    extremo correspondiente, y sumándolos. Al final deberá devolver la suma de todos los
    elementos de la cola, pero sin modificar la cola original.

    Implementa un método llamado InvierteCola que reciba como parámetro una cola de
    doubles que sumaste anteriormente y la modifique invirtiendo el orden de los elementos.
    Para realizar el proceso de invertir la cola usa el tipo Stack<T>(Pila Genérica)
    implementado ya en las BCL.
*/
{
    class Program
    {
        
        public static double SumaCola(ColaVinculada<double> cola)
        {
            double datoSumado=0;
            if (!cola.Vacia)
            {
                foreach (double dato in cola)
                {
                    datoSumado += dato;
                }
            }
            

            return datoSumado;
        }

        public static void InvierteCola(ColaVinculada<double> cola)
        {
            Stack<double> p = new Stack<double>();
            
            while (cola.Elementos > 0)
            {
                p.Push(cola.Desencola());
            }

            while (p.Count>0)
            {
                cola.Encola(p.Pop());
            }

        }

        static void Main(string[] args)
        {
            try
            {
               
                ColaVinculada<double> cola = new ColaVinculada<double>();
                cola.Encola(2.3d);
                
                cola.Encola(3.3d);
                cola.Encola(7.12d);
                

                Console.WriteLine("Cola original");
                foreach (double dato in cola)
                {
                    Console.WriteLine(dato);
                }
                InvierteCola(cola);
                Console.WriteLine("\nCola invertida");
                foreach (double dato in cola)
                {
                    Console.WriteLine(dato);
                }


                Console.WriteLine("\nSuma de la cola");
                Console.WriteLine(SumaCola(cola));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
