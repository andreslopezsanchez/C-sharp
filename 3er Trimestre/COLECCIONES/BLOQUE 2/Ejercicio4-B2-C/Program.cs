using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_B2_C
/*
    Para realizar el ejercicio usa el tipo PilaVinculada que has creado en el ejercicio 1.
    Implementa un procedimiento llamado CambiaPila que reciba como parámetros una pila
    de cadenas y las cadenas origen y reemplazo.

    Lo que deberá hacer es cambiar en la pila todas las veces que se encuentre la cadena
    origen por la cadena reemplazo. Para realizar el proceso de sustitución usa el tipo
    Queue<T>(Cola Genérica) implementado ya en las BCL.
*/
{
    class Program
    {
        public static void cambiaPila(PilaVinculada<string> pila, string origen, string reemplazo)
        {
            Queue<string> c = new Queue<string>();
            PilaVinculada<string> pilaAux = new PilaVinculada<string>();

            while (pila.Elementos>0)
            {                
                if (pila.Peek() == origen)
                {
                    pila.Desapila();
                    pila.Apila(reemplazo);
                }
                c.Enqueue(pila.Desapila());
            }

            while (c.Count>0)
            {
                pilaAux.Apila(c.Dequeue());
            }

            while (pilaAux.Elementos>0)
            {
                pila.Apila(pilaAux.Desapila());
            }
           
        }

        static void Main(string[] args)
        {

            string origen="nombre", reemplazo = "Francisco";
            PilaVinculada<string> pila = new PilaVinculada<string>();
            pila.Apila("Antonio");
            pila.Apila("nombre");
            pila.Apila("Maria");
            pila.Apila("nombre");
            pila.Apila("Pilar");
            pila.Apila("Roberto");
            pila.Apila("nombre");

            Console.WriteLine("Pila sin reemplazar:");
            foreach (string dato in pila)
            {
                Console.WriteLine(dato);
            }

            Console.WriteLine($"\nVamos a reemplazar los \"{origen}\" por \"{reemplazo}\":");
            cambiaPila( pila, "nombre", "Franciso");
          
           
            foreach (string dato in pila)
            {
                Console.WriteLine(dato);
            }
        }
    }
}
