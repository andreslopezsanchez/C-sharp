using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    /*• Crea un tipo delegado denominado Operación de parámetro 
     *  entero y de retorno entero. 
     * 
     * • En una clase estática Cálculos añade dos métodos, 
     *   con esa misma signatura, llamados Cuadrado y Cubo, que te devuelvan 
     *   el cuadrado y el cubo de un número introducido respectivamente. 
     *   
     * • Crea una aplicación en el programa principal que dependiendo 
     *   de la opción seleccionada, te muestre el resultado del cálculo 
     *   (lógicamente utilizando el objeto de tipo delegado). */


     // TIEMPO: 9' 02''
    class Program
    {

        public delegate int Operacion(int numero);

        static int Cuadrado(int numero)
        {
            return numero * numero;
        }
        static int Cubo(int numero)
        {
            return numero * numero *numero;
        }

        public static int Opera(int numero, Operacion operacion)
        {
            return operacion(numero);
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"{2} -> {Opera(2, Cuadrado)} -> {Opera(2, Cubo)}");
        }
    }
}
