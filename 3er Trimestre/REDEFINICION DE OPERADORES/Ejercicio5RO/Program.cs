using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5RO
{
    /*  Diseñar la clase Fracción, que representa el conjunto de los números racionales.
        Un número racional se representa por un numerador, que es un número entero y un
        denominador, que es un número natural.

        Esta clase debe ofrecer como mínimo los siguientes métodos públicos:

        1. Constructor que recibe el numerado y el denominador y los simplifica.

        2. Sobrescribe el método ToString(), para que devuelva una cadena con formato
           "num/den".

        3. Redefinición del operador de cast implicito y explicito, para que devulevan el valor
           real de la fracción como double.

        4. Propiedades para acceder y modificar el numerador y numerador simplificando la
           franción en caso que se modifique.

        5. En todos los casos cuando el denominador al construir, al usar las propiedades,
        etc. sea cero. Generaremos una excepción DivideByZeroException con un mensaje indicándolo.

        6. Redefiniremos las operaciones aritméticas simples, cuyo resultado será otra
           fracción en su forma simplificada:  Suma y Resta     Multiplicación     División

        7. Aplicación para probar el programa*/
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                Console.WriteLine("Dime el numerador de la primera Fraccion");
                int n1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ahora dime su denominador");
                uint d1 = uint.Parse(Console.ReadLine());
             

                Console.WriteLine();

                Console.WriteLine("Dime el numerador de la segunda Fraccion");
                int n2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ahora dime su denominador");
                uint d2 = uint.Parse(Console.ReadLine());

                Fraccion f1 = new Fraccion(n1, d1);
                Fraccion f2 = new Fraccion(n2, d2);
                
                Console.WriteLine("Suma");
                Console.WriteLine($"{f1} + {f2} = {f1 + f2}");
                Console.WriteLine("Resta");
                Console.WriteLine($"{f1} - {f2} = {f1 - f2}");
                Console.WriteLine("Multiplicacion");
                Console.WriteLine($"{f1} * {f2} = {f1 * f2}");
                Console.WriteLine("Division");
                Console.WriteLine($"{f1} / {f2} = {f1 / f2}");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            /*catch (Exception)
            {
                Console.WriteLine("Fallo en la operación");
            }*/
        }
    }
}
