using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Ex
{
    /* Crea  un programa que tome un número como parámetro en la línea de comandos, 
     * y como salida muestra el logaritmo de dicho número. El método Main llamara a un método estático 
     * al que se le pase el parámetro de entrada y nos calcule el logaritmo, este método devolverá el 
     * resultado a la función main.  
     * 
     * 1. Compilar el programa y ejecutadlo de tres formas distintas: 
     *                  ◦ Sin parámetros. 
     *                  ◦ Poniendo un parámetro no numérico. 
     *                  ◦ Poniendo un parámetro numérico. 
     * 2. Anotad las excepciones que se lanzan en cada caso (si se lanzan). 
     * 
     * 3. Modificar el código de Main para que capture las excepciones producidas y 
     * muestre los errores correspondientes en cada caso. 
     * 
     * 4. Probad de nuevo el programa igual que en el caso anterior comprobando que las excepciones son capturadas y tratadas.*/
    class Program
    {
        public static double LogaritmoNumero(string datos)
        {

            Console.WriteLine("Numero:");
            double numero = double.Parse(datos);

            double logaritmoNumero = Math.Log(numero);
            return logaritmoNumero;
        }

        static void Main(string[] args)
        {
            try
            {            
                Console.WriteLine(LogaritmoNumero(args[0]));
               
            }

            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(IndexOutOfRangeException r)
            {
                Console.WriteLine(r.Message);
            }
        }
    }
}
